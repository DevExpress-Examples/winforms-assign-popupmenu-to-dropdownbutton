using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using System.Drawing;
using System.Windows.Forms;

namespace DropDownButtonExample {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            InitDropDownButton();
        }

        private void InitDropDownButton() {
            //create DropDownButton
            DropDownButton dropDownButton = CreateDropDownButton("Button created at runtime", "MyButton", DropDownButtonExample.Properties.Resources.About, this.dropDownButton1.Size);
            dropDownButton.BringToFront();

            //create menu items
            DevExpress.XtraBars.BarButtonItem item1 = CreateBarButtonItem("Item 1", "item1", 0);
            DevExpress.XtraBars.BarButtonItem item2 = CreateBarButtonItem("Item 2", "item2", 1);

            //create and assign PopupMenu
            dropDownButton.DropDownControl = CreatePopupMenu(new BarItem[] { item1, item2 }, this.barManager1, "MyPopupMenu");
        }

        private BarButtonItem CreateBarButtonItem(string caption, string name, int imageIndex) {
            DevExpress.XtraBars.BarButtonItem item = new BarButtonItem();
            item.Caption = caption;
            item.Id = this.barManager1.GetNewItemId();            
            item.ImageIndex = imageIndex;
            item.Name = name;
            return item;
        }

        private DropDownButton CreateDropDownButton(string caption, string name, Image image, Size size) {
            DropDownButton dropDownButton = new DropDownButton() { Dock = DockStyle.Top };
            dropDownButton.Name = name;
            dropDownButton.Text = caption;
            dropDownButton.Size = size;
            dropDownButton.Image = DropDownButtonExample.Properties.Resources.About;
            this.Controls.Add(dropDownButton);       
            return dropDownButton;
        }

        private PopupMenu CreatePopupMenu(BarItem[] items, BarManager manager, string name) {
            PopupMenu menu = new PopupMenu(manager);         
            menu.Name = name;
            menu.AddItems(items);
            return menu;
        }
    }
}