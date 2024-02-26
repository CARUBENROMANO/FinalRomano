<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Menu.aspx.cs" Inherits="FinalRomano.Menu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title> Alumno carlos romano tp4</title>
<style>
        body {
            display: flex;
            flex-direction: column;
            min-height: 100vh;
            margin: 0;
        }

           nav {
            background-color: #333;
            color: #fff;
            padding: 10px;
        }

        nav a {
            color: #fff;
            text-decoration: none;
            margin-right: 15px;
        }

        nav a:hover {
            text-decoration: underline;
        }

         section {
            padding: 20px;
            margin: 10px 0;
        }

        main {
            flex: 1;
        }

        footer {
            background-color: #333;
            color: #fff;
            padding: 10px;
        }
    </style>
  



</head>
<body>
    <header>
    <nav>
        <h1> Menu</h1>

        <ul>
            <li><a href="#clientes">Clientes</a></li>
            <li><a href="#cobranzas">Cobranzas</a></li>
        </ul>

    </nav>
        </header>
    <form id="form1" runat="server">
        <div>
        </div>
    </form>
    <main >
        <div class="" id="clientes">

             <section id="seccion1">
              <h2>Cargar Acreadores</h2>

            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Acreedores.aspx">Cargar</asp:HyperLink>
                   </section>
        </div>

        <div class="" id="cobranzas">
        <section id="seccion2">
        <h2>Consultar Deudores</h2>

            <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/Deudores.aspx">Consultar</asp:HyperLink>
       </div>


    </main>

</body>

   <footer>
        <div class="" id="">
            <p>Tecnica de Programacion 4 - alumno carlos romano</p>
       </div>
   </footer>
</html>
