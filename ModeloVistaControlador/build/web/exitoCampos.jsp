<%@page import="modelo.User"%>
<%
    User userOne=(User)request.getSession().getAttribute("userOne");
%>
<%@page contentType="text/html" pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
    <head>
        <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
        <title>succefull campos</title>
    </head>
    <body>
        <h1>succefull persona</h1>
        <p>your name is: <%= userOne.getName()%></p>
        <p>your password is: <%= userOne.getPassword()%></p>
    </body>
</html>
