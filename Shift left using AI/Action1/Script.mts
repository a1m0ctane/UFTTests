﻿
SystemUtil.Run "C:\Program Files (x86)\Google\Chrome\Application\chrome.exe"

Browser("index:=0").Navigate "http://advantageonlineshopping.com"
Browser("index:=0").Sync

AIUtil.SetContext Browser("index:=0")

AIUtil("profile").Click

AIUtil("input", "Usemame").Type "UFT.AI"
AIUtil("input", "Password").Type "UFT.AI"
AIUtil("button", "SIGN IN").Click

AIUtil.FindTextBlock("Incorrect user name or password.").Exist(5)


Browser("index:=0").Close()


