    Private Sub Bounds_Tick(sender As Object, e As EventArgs) Handles Bounds.Tick
        If PBMega.Bounds.IntersectsWith(LeftBounds.Bounds) Then
            PBMega.Left = PBMega.Left + 3
        End If

        If PBMega.Bounds.IntersectsWith(GroundBound1.Bounds) Then
            PBMega.Top = PBMega.Top - 2
        End If

        If PBMega.Bounds.IntersectsWith(GroundBound2.Bounds) Then
            PBMega.Top = PBMega.Top - 10
        End If

        If PBMega.Bounds.IntersectsWith(HillBoundLeft.Bounds) Then
            PBMega.Left = PBMega.Left - 3
        End If

        If PBMega.Bounds.IntersectsWith(HillBoundTop.Bounds) Then
            PBMega.Top = PBMega.Top - 1
        End If

        If PBMega.Bounds.IntersectsWith(HillBoundRight.Bounds) Then
            PBMega.Left = PBMega.Left + 1
        End If

        If PBMega.Bounds.IntersectsWith(HillBound1Left.Bounds) Then
            PBMega.Left = PBMega.Left - 1
        End If

        If PBMega.Bounds.IntersectsWith(HillBound1Top.Bounds) Then
            PBMega.Top = PBMega.Top - 1
        End If

        If PBMega.Bounds.IntersectsWith(HillBound1Right.Bounds) Then
            PBMega.Left = PBMega.Left + 1
        End If

        If PBMega.Bounds.IntersectsWith(HillBound3Left.Bounds) Then
            PBMega.Top = PBMega.Top - 1
        End If

        If PBMega.Bounds.IntersectsWith(HillBound3Top.Bounds) Then
            PBMega.Top = PBMega.Top - 1
        End If


    End Sub
