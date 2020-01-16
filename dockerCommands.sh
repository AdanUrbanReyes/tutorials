#see the version of docker
docker version
#to see running containers
docker ps
##to se all containers
docker ps -a
#to see full information of contaner
docker inspect [id or name of container]
#to stop a container
docker stop [id or name of container]
#to start a container
docker start [id or name of container]
#to remove a container
docker rm [id or name of container]
#to see all images downloaded
docker images
#to remove a images
docker rmi [id or name of image]
#just download image
docker pull [image]
#to download (just if it is necesari) and run/start the container
docker run [image]:[tag; if you dont specify it default is latest]
#to run a container without attaching shell
docker run -d [image]
#run a container as interactive/and sudo terminal mode
docker run -it [image]
#mapping ports
docker run -p [port of host]:[port of container] [image]
#mapping volumens to a container; in this way we can keep information even if we remove the container
#example docker run -v /opt/datardier:/var/lib/mysql mysql 
docker run -v [paht of the volumen host]:[path of the volumen container] [image]
#enveroment variables; you could see it with docker inspector
docker run -e [name of environment variable]=[value] [image]
#to attach shell to container running
docker attach [id or name of container]
#to run a command in the container
docker exec [id or name of container] [command]
#to see logs
docker logs [id or name of container]
#to build an images 
docker build -t [name of images] [directory where is Dockerfile]
