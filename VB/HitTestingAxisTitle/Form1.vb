Imports System
Imports System.Windows.Forms
Imports DevExpress.XtraCharts
' ...

Namespace HitTestingAxisTitle
    Partial Public Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub chartControl1_ObjectHotTracked(ByVal sender As Object, ByVal e As HotTrackEventArgs) Handles chartControl1.ObjectHotTracked
            If TypeOf e.AdditionalObject Is AxisTitle Then
                MessageBox.Show(e.AdditionalObject.GetType().ToString())
            End If
            If TypeOf e.AdditionalObject Is AxisLabelItem Then
                MessageBox.Show(CType(e.AdditionalObject, AxisLabelItem).AxisValue.ToString())
            End If
        End Sub
    End Class
End Namespace