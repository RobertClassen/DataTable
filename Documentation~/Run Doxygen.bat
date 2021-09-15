@echo off
( type Doxyfile & type Settings.txt ) | doxygen.exe -
::PAUSE