Public Class Form1

    Dim chamber(5) As Boolean
    Dim shotsAway As Integer = 2
    Dim slot As Integer = 0
    Dim score As Integer = 0
    Dim dead = False
    Dim bulletNum As Integer = 0

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pbYou.Image = My.Resources.title
        pbYou.SizeMode = PictureBoxSizeMode.StretchImage
    End Sub

    Private Sub btnLoadSpin_Click(sender As Object, e As EventArgs) Handles btnLoadSpin.Click
        Dim rand As New Random
        Dim num As Integer

        slot = 0
        dead = False
        txtName.Enabled = False

        num = rand.Next(0, 5)
        bulletNum = num
        chamber(num) = True

        btnLoadSpin.Enabled = False
        btnFire.Enabled = True
        btnAway.Enabled = True
        btnAgain.Visible = False
        btnNext.Visible = False

        pbYou.Image = My.Resources.gun_to_head
        My.Computer.Audio.Play(My.Resources.load_n_spin, AudioPlayMode.Background)
    End Sub

    Private Sub btnFire_Click(sender As Object, e As EventArgs) Handles btnFire.Click
        If chamber(slot) = True Then
            Call GunFireSound()
            pbYou.Image = My.Resources.game_over
            dead = True
            Call RoundOver()
        ElseIf chamber(slot) = False Then
            Call EmptyGunFireSound()
            slot += 1
            score += 20
            lblScore.Text = score
        End If


    End Sub

    Private Sub btnAway_Click(sender As Object, e As EventArgs) Handles btnAway.Click
        pbYou.Image = My.Resources.gun_away
        shotsAway -= 1
        lblChances.Text = shotsAway

        If chamber(slot) = True Then
            Call GunFireSound()
            Call RoundOver()

        Else
            Call EmptyGunFireSound()
            slot += 1
            If shotsAway = 0 Then
                btnAway.Enabled = False
            End If
        End If
    End Sub

    Sub GunFireSound()
        My.Computer.Audio.Play(My.Resources.bang, AudioPlayMode.Background)
    End Sub

    Sub EmptyGunFireSound()
        My.Computer.Audio.Play(My.Resources.empty, AudioPlayMode.Background)
    End Sub

    Sub RoundOver()
        score += (shotsAway * 100)
        lblScore.Text = score
        btnSave.Visible = True
        btnLoadSpin.Enabled = False
        btnFire.Enabled = False
        btnAway.Enabled = False
        If dead = True Then
            btnAgain.Visible = True
            MsgBox("You're dead." & vbCrLf & "Your score is " & score & "." & vbCrLf & "Game Over.")
        Else
            score += 100
            lblScore.Text = score
            btnNext.Visible = True
            MsgBox("You lived!" & vbCrLf & "Your score is " & score & "." & vbCrLf & "Another round?")
        End If
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        pbYou.Image = My.Resources.title
        shotsAway = 2
        lblChances.Text = shotsAway
        btnLoadSpin.Enabled = True
        btnNext.Visible = False
        chamber(bulletNum) = False
        btnSave.Visible = False
    End Sub

    Private Sub btnAgain_Click(sender As Object, e As EventArgs) Handles btnAgain.Click
        pbYou.Image = My.Resources.title
        shotsAway = 2
        lblChances.Text = shotsAway
        score = 0
        lblScore.Text = score
        txtName.Text = ""
        txtName.Enabled = True
        btnNext.Visible = False
        chamber(bulletNum) = False
        btnAgain.Visible = False
        btnSave.Visible = False
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub txtName_TextChanged(sender As Object, e As EventArgs) Handles txtName.TextChanged
        If txtName.TextLength > 2 Then
            btnLoadSpin.Enabled = True
        ElseIf txtName.TextLength < 3 Then
            btnLoadSpin.Enabled = False
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        MsgBox("Save feature coming soon.")
    End Sub
End Class
