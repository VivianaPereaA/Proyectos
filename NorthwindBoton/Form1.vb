Public Class Form1
    Private Sub CategoriesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles CategoriesBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.CategoriesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DsCategories)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DsProveedor.Suppliers' Puede moverla o quitarla según sea necesario.
        Me.SuppliersTableAdapter.Fill(Me.DsProveedor.Suppliers)
        'TODO: esta línea de código carga datos en la tabla 'DsProducts.Products' Puede moverla o quitarla según sea necesario.
        Me.ProductsTableAdapter.Fill(Me.DsProducts.Products)
        'TODO: esta línea de código carga datos en la tabla 'DsCategories.Categories' Puede moverla o quitarla según sea necesario.
        Me.CategoriesTableAdapter.Fill(Me.DsCategories.Categories)

    End Sub

    Private Sub ProductsDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles ProductsDataGridView.CellContentClick

    End Sub

    Private Sub CategoriesBindingNavigator_RefreshItems(sender As Object, e As EventArgs) Handles CategoriesBindingNavigator.RefreshItems

        If IsNothing(CategoriesBindingSource.Current) Then
            Exit Sub
        End If
        Dim drv As DataRowView = CategoriesBindingSource.Current
            Dim cId As Integer = drv.Item("CategoryId")
        ProductsBindingSource.Filter = "CategoryId = " & cId

    End Sub
End Class
