using TicketOnline.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TicketOnline.Data;

namespace TicketOnline.Domain
{
    public class Data
    {
        public IEnumerable<Models.Navbar> navbarItems()
        {
            QLBanVeFilmEntities dbContext = new QLBanVeFilmEntities();
            dbContext.Configuration.ProxyCreationEnabled = false;
            var menu = dbContext.MenuLists;
            List<Models.Navbar> lst = new List<Models.Navbar>();
            foreach(var item in menu)
            {
                Models.Navbar enti = new Models.Navbar();
                enti.action = item.action.ToString().Trim();
                enti.controller = item.controller.ToString().Trim();
                enti.Id = item.Id;
                enti.imageClass = item.imageClass;
                enti.isParent = item.isParent.HasValue ? item.isParent.Value : false;
                enti.nameOption = item.nameOption;
                enti.parentId = item.parentId.HasValue ? item.parentId.Value : 0;
                enti.status = item.status.HasValue ? item.status.Value : false;
                lst.Add(enti);
            }
            return lst;
        }
    }
}