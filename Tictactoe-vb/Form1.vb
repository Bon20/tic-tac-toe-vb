Public Class Form1

    Public player As Integer = 2
    Public turns As Integer = 0
    Public P1 As Integer = 0
    Public P2 As Integer = 0
    Public D As Integer = 0
    Private Sub buttonClick(ByVal sender As Object, ByVal e As EventArgs) Handles C3.Click, C2.Click, C1.Click, B3.Click, B2.Click, B1.Click, A3.Click, A2.Click, A1.Click
        Dim button As Button = CType(sender, Button)

        If button.Text = "" Then

            If player Mod 2 = 0 Then
                button.Text = "X"
                player += 1
                turns += 1
            Else
                button.Text = "0"
                player += 1
                turns += 1
            End If
            If CheckDraw() = True Then
                MessageBox.Show("Draw")
                D += 1
                NewGame()
            End If
            If Winner() = True Then
                If button.Text Is "X" Then
                    MessageBox.Show("Player 1 Wins!")
                    P1 += 1
                    NewGame()
                Else
                    MessageBox.Show("Player 2 Wins")
                    P2 += 1
                    NewGame()
                End If
            End If
        End If

    End Sub

    Private Sub NewGame()
        player = 2
        turns = 0
        lblPlayer1.Text = "Player 1 : " & P1
        lblPlayer2.Text = "Player 2 : " & P2
        lblDraw.Text = "Draw : " & D
        A1.Text = ""
        A2.Text = ""
        A3.Text = ""
        B1.Text = ""
        B2.Text = ""
        B3.Text = ""
        C1.Text = ""
        C2.Text = ""
        C3.Text = ""
    End Sub

    Private Function CheckDraw() As Boolean
        If (turns = 9) AndAlso Winner() = False Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Function Winner() As Boolean
        If (A1.Text = A2.Text) AndAlso (A2.Text = A3.Text) AndAlso A1.Text <> "" Then
            Return True
        ElseIf (B1.Text = B2.Text) AndAlso (B2.Text = B3.Text) AndAlso B1.Text <> "" Then
            Return True
        ElseIf (C1.Text = C2.Text) AndAlso (C2.Text = C3.Text) AndAlso C1.Text <> "" Then
            Return True
        End If

        If (A1.Text = B1.Text) AndAlso (B1.Text = C1.Text) AndAlso A1.Text <> "" Then
            Return True
        ElseIf (A2.Text = B2.Text) AndAlso (B2.Text = C2.Text) AndAlso A2.Text <> "" Then
            Return True
        ElseIf (A3.Text = B3.Text) AndAlso (B3.Text = C3.Text) AndAlso A3.Text <> "" Then
            Return True
        End If

        If (A1.Text = B2.Text) AndAlso (B2.Text = C3.Text) AndAlso A1.Text <> "" Then
            Return True
        ElseIf (A3.Text = B2.Text) AndAlso (B2.Text = C1.Text) AndAlso A3.Text <> "" Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub btnNewGame_Click(sender As Object, e As EventArgs) Handles btnNewGame.Click

        A1.Text = ""
        A2.Text = ""
        A3.Text = ""
        B1.Text = ""
        B2.Text = ""
        B3.Text = ""
        C1.Text = ""
        C2.Text = ""
        C3.Text = ""

        lblPlayer1.Text = "Player 1: 0"
        lblPlayer2.Text = "Player 2: 0"
        lblDraw.Text = "Draw: 0"
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Dim tExit As DialogResult

        tExit = MessageBox.Show("Do you want to exit the game?", "Tic-Tac-Toe", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If tExit = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub btnAbout_Click(sender As Object, e As EventArgs) Handles btnAbout.Click
        MessageBox.Show("By Bonifacio M. De Robles Jr.", "Tic-Tac-Toe", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class
