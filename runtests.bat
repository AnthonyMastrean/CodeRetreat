@PowerShell -NonInteractive -NoProfile -ExecutionPolicy RemoteSigned -Command Import-Module .\Pester\Pester.psm1; Invoke-Pester 
@echo off
exit /B %errorlevel%