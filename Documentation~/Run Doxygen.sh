#!/bin/bash
( cat Doxyfile; cat Settings.txt ) | doxygen -
#$SHELL