Website goto: http://temach.github.io
 

always forget this stuff:

to change filetype in vim: 

`setfiletype .....`

print keyboard layout to pdf:

`setxkbmap -layout ru -variant phonetic -print | xkbcomp - - | xkbprint - - | ps2pdf - > my_layout.pdf`


for server
`http://adrianmejia.com/blog/2011/07/12/how-to-set-up-samba-in-ubuntu-linux-and-access-it-in-mac-os-and-windows/`


I turned on -debug=bench, which produced impenetrable and seemingly useless results in the log.
So I added a print with a sleep, so I could run perf.  Then I disabled optimization, so I’d get understandable backtraces with perf.  Then I rebuilt perf because Ubuntu’s perf doesn’t demangle C++ symbols, which is part of the kernel source package. (Are we having fun yet?)

Running text side-by-side in latex translation mode
see latex packages: parcolumns and parallels 
stack exchange: tex.stackexchange.com/questions/16603/putting-two-texts-side-by-side
