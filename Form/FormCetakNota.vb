Public Class FormCetakNota
    Private Sub FormCetakNota_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim paramFields As New CrystalDecisions.Shared.ParameterFields()
        Dim paramField As New CrystalDecisions.Shared.ParameterField()
        Dim discretVal As New CrystalDecisions.Shared.ParameterDiscreteValue()
        Dim paramField2 As New CrystalDecisions.Shared.ParameterField()
        Dim discretVal2 As New CrystalDecisions.Shared.ParameterDiscreteValue()
        With FormPenjualan
            paramField.ParameterFieldName = "bayar"
            Dim str As String = .txtBayar.Text
            discretVal.Value = str
            paramField.CurrentValues.Add(discretVal)
            paramFields.Add(paramField)

            paramField2.ParameterFieldName = "kembali"
            Dim str2 As String = .txtKembali.Text
            discretVal2.Value = str2
            paramField2.CurrentValues.Add(discretVal2)
            paramFields.Add(paramField2)
        End With
        CrystalReportViewer1.ParameterFieldInfo = paramFields
    End Sub
End Class