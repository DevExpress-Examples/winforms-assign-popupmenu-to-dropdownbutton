<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128622734/17.1.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E424)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->

# WinForms Popup Menu - How to use a popup menu as the dropdown of DropDownButton

The [WinForms DropDownButton](https://docs.devexpress.com/WindowsForms/DevExpress.XtraEditors.DropDownButton) control is a push button with an associated popup control. This example demonstrates how to display a popup menu when the drop-down button is clicked. The example demonstrates how to customize the `DropDownButton` at design-time and runtime.

Use the [DropDownButton.DropDownControl](https://docs.devexpress.com/WindowsForms/DevExpress.XtraEditors.DropDownButton.DropDownControl) property to assign a [PopupMenu](https://docs.devexpress.com/WindowsForms/DevExpress.XtraBars.PopupMenu) to a [DropDownButton](https://docs.devexpress.com/WindowsForms/DevExpress.XtraEditors.DropDownButton) control.

```csharp
private void InitDropDownButton() {
    // Creates the DropDownButton.
    DropDownButton dropDownButton = CreateDropDownButton("Button created at runtime", "MyButton", DropDownButtonExample.Properties.Resources.About, this.dropDownButton1.Size);
    dropDownButton.BringToFront();
    // Creates poup menu items.
    DevExpress.XtraBars.BarButtonItem item1 = CreateBarButtonItem("Item 1", "item1", 0);
    DevExpress.XtraBars.BarButtonItem item2 = CreateBarButtonItem("Item 2", "item2", 1);
    // Creates the popup menu and assigns it to the DropDownButton.
    dropDownButton.DropDownControl = CreatePopupMenu(new BarItem[] { item1, item2 }, this.barManager1, "MyPopupMenu");
}
```

## Files to Review

* [Form1.cs](./CS/DropDownButtonExample/Form1.cs) (VB: [Form1.vb](./VB/DropDownButtonExample/Form1.vb))


## Documentation

* [DropDownButton](https://docs.devexpress.com/WindowsForms/DevExpress.XtraEditors.DropDownButton)
* [PopupMenu](https://docs.devexpress.com/WindowsForms/DevExpress.XtraBars.PopupMenu)
