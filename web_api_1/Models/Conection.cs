using Microsoft.EntityFrameworkCore;

namespace web_api_1.Models{
class Conexion : DbContext{

    public Conexion(DbContextOptions<Conexion> options) : base(options){}
    public DbSet<Clientes> Clientes{get; set;}
}

class Conectar{
    private const string cadenaConexion = "server=localhost;port=3306;database=db_empresa_j;userid=usr_empresa;pwd=empres@1234";
    public static Conexion Create(){
        var constructor = new DbContextOptionsBuilder<Conexion>();
        constructor.UseMySQL(cadenaConexion);
        var cn = new Conexion(constructor.Options);
        return cn;
    }
}



}