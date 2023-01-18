```html
<html>
<head>

<meta charset="ISO-8859-1">
<title>Insert title here</title>
</head>
<body>
	<form method="post" action="TestServlet" enctype="multipart/form-data">
    <input type="file" id="file-input" name="image"    required/>

     <input type="submit" value="Upload" />
  <img id="preview" src="#" alt="Image preview" width="400">
    
  </form>
  

  <script>
  const fileInput = document.getElementById("file-input");
  const preview = document.getElementById("preview");

  fileInput.addEventListener("change", function (event) {
    const file = event.target.files[0];
    const reader = new FileReader();

    reader.onloadend = function () {
      preview.src = reader.result;
    }

    if (file) {
      reader.readAsDataURL(file);
    } else {
      preview.src = "";
    }
  });
  </script>

</body>
</html>
```
