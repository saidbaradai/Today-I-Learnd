```java

package Servlets;

import java.io.File;
import java.io.IOException;
import java.util.Collection;

import javax.servlet.ServletException;
import javax.servlet.annotation.MultipartConfig;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import javax.servlet.http.Part;

/**
 * Servlet implementation class TestServlet
 */
@WebServlet("/TestServlet")
@MultipartConfig(
		  fileSizeThreshold = 1024 * 1024 * 1, // 1 MB
		  maxFileSize = 1024 * 1024 * 10,      // 10 MB
		  maxRequestSize = 1024 * 1024 * 100   // 100 MB
		)
public class TestServlet extends HttpServlet {
	
	private static final long serialVersionUID = 1L;
	private static final String UPLOAD_DIR = "images";

	protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		// TODO Auto-generated method stub
		response.getWriter().append("Served at: ").append(request.getContextPath());
	}

	protected void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {

        String applicationPath = request.getServletContext().getRealPath("");
        String uploadFilePath = applicationPath + UPLOAD_DIR;
        


        
        Collection<Part> parts = request.getParts();
        for (Part part : parts) {
            String fileName = getFileName(part);
            String filePath = uploadFilePath + File.separator + fileName;
            if(fileName != null && !fileName.isEmpty()){
            	System.out.println(filePath);
                part.write(filePath);
            }
        }

	}
	
	
	private String getFileName(Part part) {
        for (String cd : part.getHeader("content-disposition").split(";")) {
            if (cd.trim().startsWith("filename")) {
                String fileName = cd.substring(cd.indexOf('=') + 1).trim().replace("\"", "");
                return fileName.substring(fileName.lastIndexOf('/') + 1).substring(fileName.lastIndexOf('\\') + 1); // MSIE fix.
            }
        }
        return null;
    }
	
	


}


```
