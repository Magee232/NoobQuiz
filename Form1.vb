Public Class Form1
    'Global Variables that are used throughout the form.
    Public i As Integer = 0
    'This could be a Muti-Dimensional AwnsArray(0,3)
    Public Shared Awns1() As String = New String() {"George Washinton", "John Adams", "James Monroe", "Bill Clinton"}
    Public Shared Awns2() As String = New String() {"Pluto", "Saturn", "Uranus", "Tatooeine"}
    Public Shared Awns3() As String = New String() {"8.121 Slices", "3.141", "1.136", "3.643"}
    Public Shared Awns4() As String = New String() {" Mercia", "Rio de Jenero", "Belmonpen", "Managuwa"}
    Public Shared Awns5() As String = New String() {"22", "80", "7", "21"}
    Public Shared Awns6() As String = New String() {"22", "80", "7", "443"}
    Public Shared Awns7() As String = New String() {"Spike Lee", "George Lucas", "Quentine Terntino", "Kevin Smith"}
    Public Shared Awns8() As String = New String() {"Apollo", "Aries", "Sarnestel", "Kermit the Frog"}
    Public Shared Awns9() As String = New String() {"13.2", "17.9", "23.5", "32.7"}
    Public Shared Awns10() As String = New String() {"Gary Johnson", "Hillary Clinton", "Donald Trump", "Doesn't matter we're Fucked Anyway!"}


    Public Shared strArray() As String = New String() {"What is the name of the first President",
                                                       "What is the furthest planet in our solar system?",
                                                       "What is the numeric value of pi to three deciml places?",
                                                       "What is the Capitol of Belize?",
                                                       "Which 'Well Known' Port is utilized for the File Transfer Protocol or FTP?",
                                                       "Which 'Well Known' Port is utilized for the Hyper Text Transfer Protocol or HTTP?",
                                                       "Who wrote the hit screenplay 'Jay and Silent Bob Strike Back'?",
                                                       "What is the name of the Greek God of War?",
                                                       "To what degree is the Earth tilted on its Axis?", "Who will win the 2016 Presidential Election?"}
    ' Function to display a message to the user *** Notice the difference between a Sub and a Function... A Sub
    ' Preforms an operation without returning a value   vise versa id the function
    Public Function Msg(ByVal scr As String) As String

        If CInt(scr) >= 1000 Then
            lblMsg.Text = " Congratz You Win"

        End If
        Return scr.ToString()


    End Function
    'Sub that Changes the awnsers available depending on the question displayed
    Public Sub ChngAwns()
        Select Case txtQues.Text
            Case strArray(0)
                rdb1.Text = Awns1(0)
                rdb2.Text = Awns1(1)
                rdb3.Text = Awns1(2)
                rdb4.Text = Awns1(3)
            Case strArray(1)
                rdb1.Text = Awns2(0)
                rdb2.Text = Awns2(1)
                rdb3.Text = Awns2(2)
                rdb4.Text = Awns2(3)
            Case strArray(2)
                rdb1.Text = Awns3(0)
                rdb2.Text = Awns3(1)
                rdb3.Text = Awns3(2)
                rdb4.Text = Awns3(3)
            Case strArray(3)
                rdb1.Text = Awns4(0)
                rdb2.Text = Awns4(1)
                rdb3.Text = Awns4(2)
                rdb4.Text = Awns4(3)
            Case strArray(4)
                rdb1.Text = Awns5(0)
                rdb2.Text = Awns5(1)
                rdb3.Text = Awns5(2)
                rdb4.Text = Awns5(3)
            Case strArray(5)
                rdb1.Text = Awns6(0)
                rdb2.Text = Awns6(1)
                rdb3.Text = Awns6(2)
                rdb4.Text = Awns6(3)
            Case strArray(6)
                rdb1.Text = Awns7(0)
                rdb2.Text = Awns7(1)
                rdb3.Text = Awns7(2)
                rdb4.Text = Awns7(3)
            Case strArray(7)
                rdb1.Text = Awns8(0)
                rdb2.Text = Awns8(1)
                rdb3.Text = Awns8(2)
                rdb4.Text = Awns8(3)
            Case strArray(8)
                rdb1.Text = Awns9(0)
                rdb2.Text = Awns9(1)
                rdb3.Text = Awns9(2)
                rdb4.Text = Awns9(3)
            Case strArray(9)
                rdb1.Text = Awns10(0)
                rdb2.Text = Awns10(1)
                rdb3.Text = Awns10(2)
                rdb4.Text = Awns10(3)
        End Select
        rdb1.Checked = False
        rdb2.Checked = False
        rdb3.Checked = False
        rdb4.Checked = False

    End Sub
    'Sub that Checks the awnsers and awards points depending on the question
    Public Sub ChkAwns()
        Dim score As Integer = CInt(lblScore.Text)
        Select Case txtQues.Text
            Case strArray(0)
                If rdb1.Checked = True Then
                    lblScore.Text = score + 100.ToString()
                Else
                    lblMsg.Text = "Wrong... You Suck"
                End If
            Case strArray(1)
                If rdb3.Checked = True Then
                    lblScore.Text = score + 100.ToString()
                Else
                    lblMsg.Text = "Wrong... You Suck"
                End If
            Case strArray(2)
                If rdb2.Checked = True Then
                    lblScore.Text = score + 100.ToString()
                Else
                    lblMsg.Text = "Wrong... You Suck"
                End If
            Case strArray(3)
                If rdb3.Checked = True Then
                    lblScore.Text = score + 100.ToString()
                Else
                    lblMsg.Text = "Wrong... You Suck"
                End If
            Case strArray(4)
                If rdb4.Checked = True Then
                    lblScore.Text = score + 100.ToString()
                Else
                    lblMsg.Text = "Wrong... You Suck"
                End If
            Case strArray(5)
                If rdb2.Checked = True Then
                    lblScore.Text = score + 100.ToString()
                Else
                    lblMsg.Text = "Wrong... You Suck"
                End If
            Case strArray(6)
                If rdb4.Checked = True Then
                    lblScore.Text = score + 100.ToString()
                Else
                    lblMsg.Text = "Wrong... You Suck"
                End If
            Case strArray(7)
                If rdb2.Checked = True Then
                    lblScore.Text = score + 100.ToString()
                Else
                    lblMsg.Text = "Wrong... You Suck"
                End If
            Case strArray(8)
                If rdb3.Checked = True Then
                    lblScore.Text = score + 100.ToString()
                Else
                    lblMsg.Text = "Wrong... You Suck"
                End If
            Case strArray(9)
                If rdb4.Checked = True Then
                    lblScore.Text = score + 100.ToString()
                Else
                    lblMsg.Text = "Wrong... You Suck"
                End If
        End Select

        Msg(lblScore.Text)
    End Sub
    'Form Load event to intialize values and question/awnsers displayed on the form
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim score As Integer = 0
        txtQues.Text = strArray(0)
        If txtQues.Text = strArray(0) Then
            ChngAwns()
        End If
        lblScore.Text = score.ToString()


    End Sub
    'Button click event that calls the methods and handles most of the functionality of the program
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ChkAwns()
        If i < strArray.Length - 1 Then
            i = i + 1
        Else
            i = 0
        End If
        txtQues.Text = strArray(i)
        ChngAwns()


    End Sub
    ' btn click for next question
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If i < strArray.Length - 1 Then
            i = i + 1

        End If

        txtQues.Text = strArray(i)
        ChngAwns()
    End Sub
    ' button click for previous question
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If i <= 0 Then
            i = 0
        Else
            i = i - 1
        End If
        txtQues.Text = strArray(i)
        ChngAwns()
    End Sub
    ' btn click for rest of the quiz
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim score As Integer = 0
        txtQues.Text = strArray(0)
        If txtQues.Text = strArray(0) Then
            ChngAwns()
        End If
        lblScore.Text = score.ToString()
        lblMsg.Text = ""
    End Sub
End Class
