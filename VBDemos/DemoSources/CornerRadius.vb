Namespace FormFormat
    Public Class CornerRadius
        Public Shared Sub FormRoundRadius(ByVal obj As Form, ByVal radius As Int32)
            obj.FormBorderStyle = FormBorderStyle.None

            Dim DGP As New Drawing2D.GraphicsPath
            DGP.StartFigure()

            'TOP LEFT CORNER
            DGP.AddArc(New Rectangle(0, 0, radius, radius), 180, 90)
            DGP.AddLine(radius, 0, obj.Width - radius, 0)

            'TOP RIGHT CORNER
            DGP.AddArc(New Rectangle(obj.Width - radius, 0, radius, radius), -90, 90)
            DGP.AddLine(obj.Width, radius, obj.Width, obj.Height - radius)

            'BUTTOM RIGHT CORNER
            DGP.AddArc(New Rectangle(obj.Width - radius, obj.Height - radius, radius, radius), 0, 90)
            DGP.AddLine(obj.Width - radius, obj.Height, radius, obj.Height)

            'BUTTOM LEFT CORNER
            DGP.AddArc(New Rectangle(0, obj.Height - radius, radius, radius), 90, 90)
            DGP.CloseFigure()

            obj.Region = New Region(DGP)
        End Sub

        Public Shared Sub ObjectRoundRadius(ByVal obj As Object, ByVal radius As Int32)
            Dim DGP As New Drawing2D.GraphicsPath
            DGP.StartFigure()

            'TOP LEFT CORNER
            DGP.AddArc(New Rectangle(0, 0, radius, radius), 180, 90)
            DGP.AddLine(radius, 0, obj.Width - radius, 0)

            'TOP RIGHT CORNER
            DGP.AddArc(New Rectangle(obj.Width - radius, 0, radius, radius), -90, 90)
            DGP.AddLine(obj.Width, radius, obj.Width, obj.Height - radius)

            'BUTTOM RIGHT CORNER
            DGP.AddArc(New Rectangle(obj.Width - radius, obj.Height - radius, radius, radius), 0, 90)
            DGP.AddLine(obj.Width - radius, obj.Height, radius, obj.Height)

            'BUTTOM LEFT CORNER
            DGP.AddArc(New Rectangle(0, obj.Height - radius, radius, radius), 90, 90)
            DGP.CloseFigure()

            obj.Region = New Region(DGP)
        End Sub
    End Class

End Namespace
