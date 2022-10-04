@echo off
set /p MSG="Message: "
git add .
git commit %MSG%
git push
pause