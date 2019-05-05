using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TicketOnline.Controllers
{
    public class SystemsController : Controller
    {
        // GET: Systems
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult BackUp()
        {
            return View();
        }
        public ActionResult ResetPassword()
        {
            return View();
        }
        public JsonResult BackupDatabase()
        {
            try
            {
                Random rnd = new Random();
                string fileName = "QLyBanVeDB" + DateTime.Now.ToString("dd-MM-yyyy-HH-mm") + rnd.Next(1, 9999);
                string fullFilePath = HttpContext.Server.MapPath("~\\Backup\\") + fileName + ".bak";
                FileInfo MyFile = new FileInfo(fullFilePath);
                if (MyFile.Exists == false)
                {
                    FileStream fs = MyFile.Create();
                    fs.Close();
                }
                SqlCommand cmd = null;
                SqlConnection conn = null;
                try
                {
                    String sqlBackup = @"BACKUP DATABASE " + "QLBanVeFilm" + " TO DISK = '" + fullFilePath + "'";
                    string connStr = @"server =" + "DESKTOP-NJN683L" + "; database = " + "QLBanVeFilm" + ";integrated security = false;uid =" + "sa" + ";pwd =" + "12345678" + ";";
                    conn = new SqlConnection(connStr);
                    cmd = new SqlCommand(sqlBackup, conn);
                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }
                    cmd.ExecuteNonQuery();
                }
                catch
                { 
                    return this.Json(null, JsonRequestBehavior.AllowGet);
                }
                finally
                {
                    if (cmd != null) cmd.Dispose();
                    if (conn.State == ConnectionState.Open)
                    {
                        conn.Close();
                    }
                }

                string url = @"BackupRestoreData/" + fileName + ".bak";
                return Json(new { url = url, result = "success" }, JsonRequestBehavior.AllowGet);
            }
            catch
            { 
                return this.Json(null, JsonRequestBehavior.AllowGet);
            }
        }
    }
}