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

        'resetting variables in case this is the second game or round
        slot = 0
        dead = False
        txtName.Enabled = False

        'making a random chamber in the gun contain the bullet
        num = rand.Next(0, 5)
        chamber(num) = True
        'keeping track of which chamber it is for later
        bulletNum = num

        'initializing essentials for program
        btnLoadSpin.Enabled = False
        btnFire.Enabled = True
        btnAway.Enabled = True
        btnAgain.Visible = False
        btnNext.Visible = False

        'change picture appropriate for the step that the player is in, in the game
        pbYou.Image = My.Resources.gun_to_head
        My.Computer.Audio.Play(My.Resources.load_n_spin, AudioPlayMode.Background)
    End Sub

    Private Sub btnFire_Click(sender As Object, e As EventArgs) Handles btnFire.Click
        'if chamber has a bullet
        If chamber(slot) = True Then
            Call GunFireSound()
            'game over
            pbYou.Image = My.Resources.game_over
            dead = True
            Call RoundOver()
            'otherwise
        ElseIf chamber(slot) = False Then
            Call EmptyGunFireSound()
            'line up next chamber, give points and update score
            slot += 1
            score += 20
            lblScore.Text = score
        End If


    End Sub

    Private Sub btnAway_Click(sender As Object, e As EventArgs) Handles btnAway.Click
        pbYou.Image = My.Resources.gun_away
        'give player feedback on how many shots away they have left
        shotsAway -= 1
        lblChances.Text = shotsAway

        'if chamber contains bullet
        If chamber(slot) = True Then
            'you win
            Call GunFireSound()
            Call RoundOver()
            'otherwise
        Else
            'you carry on playing
            Call EmptyGunFireSound()
            slot += 1
            'if you have no shots away left you cannot shoot away anymore
            If shotsAway = 0 Then
                btnAway.Enabled = False
            End If
        End If
    End Sub

    Sub GunFireSound()
        'bang
        My.Computer.Audio.Play(My.Resources.bang, AudioPlayMode.Background)
    End Sub

    Sub EmptyGunFireSound()
        'click
        My.Computer.Audio.Play(My.Resources.empty, AudioPlayMode.Background)
    End Sub

    'handles whether you win or lose
    Sub RoundOver()
        'give player 100 points per shots away they had left and update score
        score += (shotsAway * 100)
        lblScore.Text = score
        'allow player to save game
        btnSave.Visible = True
        'reset buttons for new game
        btnLoadSpin.Enabled = False
        btnFire.Enabled = False
        btnAway.Enabled = False
        'if you lost
        If dead = True Then
            'allow player to play again
            btnAgain.Visible = True
            'give player feedback on their loss and what their score was
            MsgBox("You're dead." & vbCrLf & "Your score is " & score & "." & vbCrLf & "Game Over.")
            'otherwise
        Else
            'give player 100 points for winning the round and update score
            score += 100
            lblScore.Text = score
            'allow the player to play another round
            btnNext.Visible = True
            'give player feedback on their win and what their score was
            MsgBox("You lived!" & vbCrLf & "Your score is " & score & "." & vbCrLf & "Another round?")
        End If
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        'return the title screen
        pbYou.Image = My.Resources.title
        'reset variables and buttons for new game, update feedback
        shotsAway = 2
        lblChances.Text = shotsAway
        btnLoadSpin.Enabled = True
        btnNext.Visible = False
        chamber(bulletNum) = False
        btnSave.Visible = False
    End Sub

    Private Sub btnAgain_Click(sender As Object, e As EventArgs) Handles btnAgain.Click
        'return to title screen
        pbYou.Image = My.Resources.title
        'reset variables and update feedback so player can begin new game and enter new name
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
        'if length of player name is 3
        If txtName.TextLength > 2 Then
            'allow player to begin
            btnLoadSpin.Enabled = True
            'otherwise
        ElseIf txtName.TextLength < 3 Then
            'dont allow them to start
            btnLoadSpin.Enabled = False
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        'TO DO
        MsgBox("Save feature coming soon.")
    End Sub
End Class
