Imports System.Data.OleDb
Imports System.Data
Imports System.Web.UI.WebControls
Partial Class Default2
    Inherits System.Web.UI.Page
End Class
Public Class WebForm2
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = " "
        TextBox2.Text = " "
        TextBox3.Text = " "
        TextBox4.Text = " "
        TextBox5.Text = " "
        TextBox6.Text = " "
        TextBox7.Text = " "
        TextBox8.Text = " "

    End Sub

    Protected Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim con As New OleDbConnection
        con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Surya\source\repos\student.mdb"
        Dim cmd As New OleDbCommand
        cmd.CommandText = "select * from Student_details"
        cmd.Connection = con
        Dim adab As New OleDbDataAdapter(cmd)
        Dim ds As New Data.DataSet
        adab.Fill(ds, "Student_details")
        GridView1.DataSource = ds
        GridView1.DataBind()

    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim con As New OleDbConnection
        con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Surya\source\repos\student.mdb"
        Dim cmd As New OleDbCommand
        cmd.CommandText = "insert into Student_details values('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "','" & TextBox6.Text & "', '" & TextBox7.Text & "','" & TextBox8.Text & "')"
        cmd.Connection = con
        con.Open()
        cmd.ExecuteNonQuery()
        con.Close()

    End Sub

    Protected Sub LinkButton1_Click(sender As Object, e As EventArgs) Handles LinkButton1.Click
        Response.Redirect("webform1.aspx")

    End Sub


End Class