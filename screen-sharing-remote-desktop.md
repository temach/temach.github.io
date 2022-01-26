#Multiple solutions

## P2P solution (no hosting needed)
wireguard tunnel + local X server + apache guacamole (web access to your X server)

#### Wireguard
Simple for linux + linux: https://www.wireguard.com/quickstart/

Instructions for Mac: https://blog.scottlowe.org/2021/04/01/using-wireguard-on-macos/


#### Guacamole (a pain to setup the first time)

Manual steps summary: https://www.systems.dance/2021/01/apache-guacamole-and-docker-compose/

Automated steps: https://pypi.org/project/guacamole-compose/

Useful links:
- https://bbs.archlinux.org/viewtopic.php?id=243806
- https://www.reddit.com/r/archlinux/comments/jzdskx/guacamole/
- https://hub.docker.com/r/guacamole/guacamole


## Server hosted solution
headless server + tigerVNC (has X server stub) + noVNC server (web access to tigerVNC)

Different x server stub implementations:
- https://unix.stackexchange.com/questions/129432/vnc-server-without-x-window-system
- https://www.reddit.com/r/linuxquestions/comments/5s645w/need_to_install_x_and_vnc_on_a_headless_linux/

