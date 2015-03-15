Public Class Form1

    Private Sub btnCompute_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCompute.Click
        Dim staminaList As New List(Of Integer)
        CreateList(staminaList)
        For I As Integer = 0 To 12
            For J As Integer = 0 To 12
                If Not IsNumeric(staminaList.Item(J)) Then
                    MessageBox.Show("Check your values dummy", "Value Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
            Next
            CalcTPC(staminaList)
        Next
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub CreateList(ByRef staminaList As List(Of Integer))
        staminaList.Add(pTxt1.Text)
        staminaList.Add(pTxt2.Text)
        staminaList.Add(pTxt3.Text)
        staminaList.Add(pTxt4.Text)
        staminaList.Add(pTxt5.Text)
        staminaList.Add(pTxt6.Text)
        staminaList.Add(pTxt7.Text)
        staminaList.Add(pTxt8.Text)
        staminaList.Add(pTxt9.Text)
        staminaList.Add(pTxt10.Text)
        staminaList.Add(pTxt11.Text)
        staminaList.Add(pTxt12.Text)
        staminaList.Add(pTxt13.Text)
    End Sub

    Private Sub CalcTPC(ByRef staminaList As List(Of Integer))
        Dim tpcList As New List(Of Integer)
        tpcTxt1.Text = staminaList.Item(0) * 1.3
        tpcList.Add(tpcTxt1.Text)
        tpcTxt2.Text = staminaList.Item(1) * 1.3
        tpcList.Add(tpcTxt2.Text)
        tpcTxt3.Text = staminaList.Item(2) * 1.3
        tpcList.Add(tpcTxt3.Text)
        tpcTxt4.Text = staminaList.Item(3) * 1.3
        tpcList.Add(tpcTxt4.Text)
        tpcTxt5.Text = staminaList.Item(4) * 1.3
        tpcList.Add(tpcTxt5.Text)
        tpcTxt6.Text = staminaList.Item(5) * 1.3
        tpcList.Add(tpcTxt6.Text)
        tpcTxt7.Text = staminaList.Item(6) * 1.3
        tpcList.Add(tpcTxt7.Text)
        tpcTxt8.Text = staminaList.Item(7) * 1.3
        tpcList.Add(tpcTxt8.Text)
        tpcTxt9.Text = staminaList.Item(8) * 1.3
        tpcList.Add(tpcTxt9.Text)
        tpcTxt10.Text = staminaList.Item(9) * 1.3
        tpcList.Add(tpcTxt10.Text)
        tpcTxt11.Text = staminaList.Item(10) * 1.3
        tpcList.Add(tpcTxt11.Text)
        tpcTxt12.Text = staminaList.Item(11) * 1.3
        tpcList.Add(tpcTxt12.Text)
        tpcTxt13.Text = staminaList.Item(12) * 1.3
        tpcList.Add(tpcTxt13.Text)
        CalcMPC(tpcList)
    End Sub

    Private Sub CalcMPC(ByRef tpcList As List(Of Integer))
        Dim textBox As New TextBox
        mpcTxt1.Text = tpcList.Item(0) + 10
        mpcTxt2.Text = tpcList.Item(1) + 10
        mpcTxt3.Text = tpcList.Item(2) + 10
        mpcTxt4.Text = tpcList.Item(3) + 10
        mpcTxt5.Text = tpcList.Item(4) + 10
        mpcTxt6.Text = tpcList.Item(5) + 10
        mpcTxt7.Text = tpcList.Item(6) + 10
        mpcTxt8.Text = tpcList.Item(7) + 10
        mpcTxt9.Text = tpcList.Item(8) + 10
        mpcTxt10.Text = tpcList.Item(9) + 10
        mpcTxt11.Text = tpcList.Item(10) + 10
        mpcTxt12.Text = tpcList.Item(11) + 10
        mpcTxt13.Text = tpcList.Item(12) + 10
    End Sub
End Class
