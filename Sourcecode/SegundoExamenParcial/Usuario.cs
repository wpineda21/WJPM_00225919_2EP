namespace SegundoExamenParcial
{
    public class Usuario
    {
        public  int Userid { get; set; }
        public string NombreUsuario { get; set; }
        public string UserName { get; set; }
        public string contrasena { get; set; }
        public bool admin { get; set; }
       

        public Usuario()
        {
            Userid = 0;    
            NombreUsuario = "";
            UserName = "";
            contrasena = "";
            admin = false;
            
                 }
    }
}