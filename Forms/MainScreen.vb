Public Class frmMainScreen
    Private Sub frmMainScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'OMSysOrdersDBDataSet.OMSys_OrdersV2DB' table. You can move, or remove it, as needed.
        Me.OMSys_OrdersV2DBTableAdapter.Fill(Me.OMSysOrdersDBDataSet.OMSys_OrdersV2DB)

    End Sub

    Private Sub OMSys_OrdersDBBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.OMSys_OrdersV2DBBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.OMSysOrdersDBDataSet)
    End Sub

    Private Sub btnAddOrder_Click(sender As Object, e As EventArgs) Handles btnAddOrder.Click
        OMSys_OrdersV2DBBindingSource.AddNew()
    End Sub

    Private Sub btnDeleteOrder_Click_1(sender As Object, e As EventArgs) Handles btnDeleteOrder.Click
        Dim choice As DialogResult = MessageBox.Show("Are you sure you want to delete this order?", "Delete", MessageBoxButtons.YesNo)
        If choice = DialogResult.Yes Then

            Try
                OMSys_OrdersV2DBBindingSource.RemoveCurrent()
                OMSys_OrdersV2DBTableAdapter.Update(OMSysOrdersDBDataSet)
            Catch ex As Exception

            End Try

        End If
    End Sub

    Private Sub btnUpdateOrder_Click_1(sender As Object, e As EventArgs) Handles btnUpdateOrder.Click
        If IDTextBox.Text = "" Or Customer_NameTextBox.Text = "" Or Product_NameTextBox.Text = "" Or
            QuantityTextBox.Text = "" Then

            MessageBox.Show("Please fill the required field/s.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Try
                OMSys_OrdersV2DBTableAdapter.Update(OMSysOrdersDBDataSet)
                OMSys_OrdersV2DBBindingSource.EndEdit()
                OMSys_OrdersV2DBTableAdapter.Update(OMSysOrdersDBDataSet)
                MessageBox.Show("Data Saved.", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Catch ex As Exception
                MessageBox.Show(ex.ToString)
            End Try
        End If
    End Sub
End Class