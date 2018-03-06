Imports System.Data.SqlServerCe

Public Class frmRaceWaySetup

    Private Sub butAddTrack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butAddTrack.Click
        Dim message, title, defaultValue As String
        Dim myValue As Object
        ' Set prompt.
        message = "Enter the description of the track to add to the Raceway."
        ' Set title.
        title = "Enter Track Description"
        defaultValue = ""   ' Set default value.

        ''' added New comment here

        ' Display message, title, and default value.
        myValue = InputBox(message, title, defaultValue)
        ' If user has clicked Cancel, set myValue to defaultValue
        If myValue Is "" Then Exit Sub
        'add track to database


        Dim sqlcon As New SqlCeConnection("Data Source=F:\SqlCEDatabases\RacewayDataBase.sdf; Password='shanedog';Persist Security Info=False;")
        sqlcon.Open()
        Dim sqlstr As String
        sqlstr = "insert Tracks (TrackName) Values ('" & RTrim(myValue.ToString) & "')"

        Dim sqlcmd As New SqlCeCommand(sqlstr, sqlcon)
        sqlcmd.ExecuteNonQuery()

        ' reload(tracks)

        LoadTracks()


    End Sub

    Private Sub LoadTracks()
        Dim sqlstr As String
        Dim sqlcon As New SqlCeConnection("Data Source=C:\SqlCEDatabases\PointsDB.sdf; Password='';Persist Security Info=False;")
        sqlcon.Open()
        sqlstr = "Select * from Tracks"
        Dim sqlda As New SqlCeDataAdapter(sqlstr, sqlcon)
        Dim sqlds As New DataSet
        sqlda.Fill(sqlds)

        sqlstr = "select * from RacewayInfo"
        Dim racda As New SqlCeDataAdapter(sqlstr, sqlcon)
        Dim racds As New DataSet

        txtRacewayName.Text = ""
        txtRacewayAddr.Text = ""

        racda.Fill(racds)
        For Each dr1 As DataRow In racds.Tables(0).Rows
            txtRacewayName.Text = RTrim(dr1.Item("RacewayName").ToString)
            txtRacewayAddr.Text = RTrim(dr1.Item("RacewayAddr").ToString)
        Next

        sqlcon.Close()
        cmbTracks.Items.Clear()


        For Each dr As DataRow In sqlds.Tables(0).Rows
            cmbTracks.Items.Add(RTrim(dr.Item("Trackname").ToString))
        Next



    End Sub

    Private Sub frmRaceWaySetup_Deactivate(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Deactivate
        UpdateRaceway()

    End Sub

    Private Sub frmRaceWaySetup_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        LoadTracks()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ''delete selected track

        Dim sqlcon As New SqlCeConnection("Data Source=C:\SqlCEDatabases\PointsDB.sdf; Password='';Persist Security Info=False;")
        sqlcon.Open()
        Dim sqlstr As String
        sqlstr = "delete Tracks where TrackName = '" & cmbTracks.Text & "'"

        Dim sqlcmd As New SqlCeCommand(sqlstr, sqlcon)
        sqlcmd.ExecuteNonQuery()

        cmbTracks.Text = ""
        'reload(tracks)

        LoadTracks()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        UpdateRaceway()
        Me.Close()
    End Sub

    Private Sub UpdateRaceway()
        Dim sqlcon As New SqlCeConnection("Data Source=C:\SqlCEDatabases\Points.sdf; Password='';Persist Security Info=False;")
        sqlcon.Open()
        Dim sqlstr As String
        sqlstr = "Update RacewayInfo set RacewayName = '" & RTrim(txtRacewayName.Text) & "', RacewayAddr =  '" & RTrim(txtRacewayAddr.Text) & "'"


        Dim sqlcmd As New SqlCeCommand(sqlstr, sqlcon)
        sqlcmd.ExecuteNonQuery()
    End Sub
End Class