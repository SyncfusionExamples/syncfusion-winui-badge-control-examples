using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Badge_without_BadgeContainer
{
    public class ListItem {
        public string ItemName { get; set; }
        public int? UnreadMessageount { get; set; }
    }

    public class ViewModel {
        public List<ListItem> MailItems { get; set; }

        public ViewModel() {
            MailItems = new List<ListItem>();
            MailItems.Add(new ListItem() { ItemName = "Inbox", 
                UnreadMessageount = 20 });
            MailItems.Add(new ListItem() { ItemName = "Drafts", 
                UnreadMessageount = null });
            MailItems.Add(new ListItem() { ItemName = "Sent Intems", 
                UnreadMessageount = 5 });
            MailItems.Add(new ListItem() { ItemName = "Deleted Items",
                UnreadMessageount = null });
            MailItems.Add(new ListItem() { ItemName = "Junk Email",
                UnreadMessageount = null });
        }
    }



}
