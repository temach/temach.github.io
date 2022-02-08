# Multiple solutions

noVNC vs Guacamole: https://news.ycombinator.com/item?id=8168264

## P2P solution (no hosting needed)
wireguard tunnel + local X server + VNC server + apache guacamole (web access to VNC) 

#### Wireguard
Simple for linux + linux: https://www.wireguard.com/quickstart/

Instructions for Mac: https://blog.scottlowe.org/2021/04/01/using-wireguard-on-macos/

#### TigerVNC
Install:
https://wiki.archlinux.org/title/TigerVNC#Installation

Add user (mandatory):
```
$ cat /etc/tigervnc/vncserver.users
# TigerVNC User assignment
#
# This file assigns users to specific VNC display numbers.
# The syntax is <display>=<username>. E.g.:
#
# :2=andrew
# :3=lisa
:1=artem
```

Configure and disable security: https://bbs.archlinux.org/viewtopic.php?id=243806
```
$ cat ~/.vnc/config
session=fluxbox
geometry=1920x1080
alwaysshared
SecurityTypes=None
```

Run (can not run on the same display that is occupied by $DISPLAY):
```
systemctl start vncserver@:1.service
sudo journalctl -xeu vncserver@:1.service
```

#### Guacamole (a pain to setup the first time)

Manual steps summary: https://www.systems.dance/2021/01/apache-guacamole-and-docker-compose/

Automated steps: https://github.com/boschkundendienst/guacamole-docker-compose/blob/master/docker-compose.yml

#### Connect remote users

Connect from remote: https://ip-of-wireguard-machine:8443/

Useful links:
- https://www.reddit.com/r/archlinux/comments/jzdskx/guacamole/
- https://hub.docker.com/r/guacamole/guacamole


## Server hosted solution
headless server + tigerVNC (has X server stub) + noVNC server (web access to tigerVNC)

Different x server stub implementations:
- https://unix.stackexchange.com/questions/129432/vnc-server-without-x-window-system
- https://www.reddit.com/r/linuxquestions/comments/5s645w/need_to_install_x_and_vnc_on_a_headless_linux/



## RDV / VNC alternatives

- NoMachine based on NX protocol: https://www.nomachine.com/download/download&id=1 (also: https://en.wikipedia.org/wiki/NX_technology)
- ThinLinc server and client: https://www.cendio.com/thinlinc/download (also: https://www.reddit.com/r/linux_gaming/comments/qkiwza/headless_remote_gaming_machine_tutorial/)
- Windows only? https://store.steampowered.com/remoteplay
- Not sure what is this: https://gaminganywhere.org/perf.html
