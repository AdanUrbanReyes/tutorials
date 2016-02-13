package controlador;

import java.io.IOException;
import javax.servlet.ServletException;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import modelo.User;
public class Procesar extends HttpServlet {
    protected void doGet(HttpServletRequest request, HttpServletResponse response)
            throws ServletException, IOException {
    }

    protected void doPost(HttpServletRequest request, HttpServletResponse response)
            throws ServletException, IOException {
        String name=request.getParameter("name");
        String password=request.getParameter("password");
        if(name.equals("")||password.equals("")){
            request.getRequestDispatcher("errorCampos.html").forward(request,response);
        }else{
            User u=new User(name,password);
            /*
                se almasena en un lugar global donde todos las vistas y todos los archivos pueden tener acceso
                ese ambito es la session
            */
            request.getSession().setAttribute("userOne",u);
            request.getRequestDispatcher("exitoCampos.jsp").forward(request,response);
        }
    }
}
