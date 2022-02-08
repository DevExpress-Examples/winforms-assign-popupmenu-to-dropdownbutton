Imports DevExpress.XtraBars
Imports DevExpress.XtraEditors
Imports System.Drawing
Imports System.Windows.Forms

Namespace DropDownButtonExample

    Public Partial Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
            InitDropDownButton()
        End Sub

        Private Sub InitDropDownButton()
            'create DropDownButton
            Dim dropDownButton As DropDownButton = CreateDropDownButton("Button created at runtime", "MyButton", Properties.Resources.About, dropDownButton1.Size)
            dropDownButton.BringToFront()
            'create menu items
            Dim item1 As BarButtonItem = CreateBarButtonItem("Item 1", "item1", 0)
            Dim item2 As BarButtonItem = CreateBarButtonItem("Item 2", "item2", 1)
            'create and assign PopupMenu
            dropDownButton.DropDownControl = CreatePopupMenu(New BarItem() {item1, item2}, barManager1, "MyPopupMenu")
        End Sub

        Private Function CreateBarButtonItem(ByVal caption As String, ByVal name As String, ByVal imageIndex As Integer) As BarButtonItem
            Dim item As BarButtonItem = New BarButtonItem()
            item.Caption = caption
            item.Id = barManager1.GetNewItemId()
            item.ImageOptions.ImageIndex = imageIndex
            item.Name = name
            Return item
        End Function

        Private Function CreateDropDownButton(ByVal caption As String, ByVal name As String, ByVal image As Image, ByVal size As Size) As DropDownButton
            Dim dropDownButton As DropDownButton = New DropDownButton() With {.Dock = DockStyle.Top}
            dropDownButton.Name = name
            dropDownButton.Text = caption
            dropDownButton.Size = size
            dropDownButton.ImageOptions.Image = Properties.Resources.About
            Me.Controls.Add(dropDownButton)
            Return dropDownButton
        End Function

        Private Function CreatePopupMenu(ByVal items As BarItem(), ByVal manager As BarManager, ByVal name As String) As PopupMenu
            Dim menu As PopupMenu = New PopupMenu(manager)
            menu.Name = name
            menu.AddItems(items)
            Return menu
        End Function
    End Class
End Namespace
