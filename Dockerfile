FROM openjdk:8-jdk-alpine
VOLUME /tmp
ADD target/SayHello.war app.jar
ENTRYPOINT ["java", "-jar", "/app.jar"]
