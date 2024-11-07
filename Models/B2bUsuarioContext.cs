using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WebApi.Models;

public partial class B2bUsuarioContext : DbContext
{
    public B2bUsuarioContext()
    {
    }

    public B2bUsuarioContext(DbContextOptions<B2bUsuarioContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Asistencia> Asistencias { get; set; }

    public virtual DbSet<AsistenciaUsuario> AsistenciaUsuarios { get; set; }

    public virtual DbSet<CentroCosto> CentroCostos { get; set; }

    public virtual DbSet<Ciudad> Ciudads { get; set; }

    public virtual DbSet<Comuna> Comunas { get; set; }

    public virtual DbSet<Conexion> Conexions { get; set; }

    public virtual DbSet<Contacto> Contactos { get; set; }

    public virtual DbSet<Departamento> Departamentos { get; set; }

    public virtual DbSet<DiccionarioError> DiccionarioErrors { get; set; }

    public virtual DbSet<Distrito> Distritos { get; set; }

    public virtual DbSet<Empresa> Empresas { get; set; }

    public virtual DbSet<ErrorSistema> ErrorSistemas { get; set; }

    public virtual DbSet<ErrorUsuario> ErrorUsuarios { get; set; }

    public virtual DbSet<Hoja1> Hoja1s { get; set; }

    public virtual DbSet<ImpresoraServidor> ImpresoraServidors { get; set; }

    public virtual DbSet<ImpresoraSistema> ImpresoraSistemas { get; set; }

    public virtual DbSet<Mensaje> Mensajes { get; set; }

    public virtual DbSet<MensajeUsuario> MensajeUsuarios { get; set; }

    public virtual DbSet<Menu> Menus { get; set; }

    public virtual DbSet<MenuReporte> MenuReportes { get; set; }

    public virtual DbSet<Operador> Operadors { get; set; }

    public virtual DbSet<OperadorSistema> OperadorSistemas { get; set; }

    public virtual DbSet<Pai> Pais { get; set; }

    public virtual DbSet<Permiso> Permisos { get; set; }

    public virtual DbSet<Provincium> Provincia { get; set; }

    public virtual DbSet<Rol> Rols { get; set; }

    public virtual DbSet<RolSucursal> RolSucursals { get; set; }

    public virtual DbSet<Sistema> Sistemas { get; set; }

    public virtual DbSet<SistemaEmpresa> SistemaEmpresas { get; set; }

    public virtual DbSet<SucTmpEntel> SucTmpEntels { get; set; }

    public virtual DbSet<SucursalTemp> SucursalTemps { get; set; }

    public virtual DbSet<TableSize> TableSizes { get; set; }

    public virtual DbSet<TblEstadoTarea> TblEstadoTareas { get; set; }

    public virtual DbSet<TblTarea> TblTareas { get; set; }

    public virtual DbSet<TblTipoTarea> TblTipoTareas { get; set; }

    public virtual DbSet<Tiendum> Tienda { get; set; }

    public virtual DbSet<TipoError> TipoErrors { get; set; }

    public virtual DbSet<ToolTipMensaje> ToolTipMensajes { get; set; }

    public virtual DbSet<ToolTipMensajeUsuario> ToolTipMensajeUsuarios { get; set; }

    public virtual DbSet<Usuario> Usuarios { get; set; }

    public virtual DbSet<UsuarioAnovo> UsuarioAnovos { get; set; }

    public virtual DbSet<UsuarioMenu> UsuarioMenus { get; set; }

    public virtual DbSet<UsuarioPai> UsuarioPais { get; set; }

    public virtual DbSet<UsuarioSistema> UsuarioSistemas { get; set; }

    public virtual DbSet<UsuarioSistemaSupervisor> UsuarioSistemaSupervisors { get; set; }

    public virtual DbSet<UsuarioTiendum> UsuarioTienda { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){}

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Asistencia>(entity =>
        {
            entity.HasKey(e => e.IdAsistencia).HasName("PK__Asistenc__4E1AB894FAE34AB5");

            entity.Property(e => e.IdAsistencia).HasColumnName("idAsistencia");
            entity.Property(e => e.DiasLaborales).HasColumnName("diasLaborales");
            entity.Property(e => e.Fecha).HasColumnName("fecha");
        });

        modelBuilder.Entity<AsistenciaUsuario>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("AsistenciaUsuario");

            entity.Property(e => e.Ausencias).HasColumnName("ausencias");
            entity.Property(e => e.DiasTrabajados).HasColumnName("diasTrabajados");
            entity.Property(e => e.IdAsistencia).HasColumnName("idAsistencia");
            entity.Property(e => e.IdUsuario).HasColumnName("idUsuario");
            entity.Property(e => e.Licencia).HasColumnName("licencia");
            entity.Property(e => e.Vacaciones).HasColumnName("vacaciones");

            entity.HasOne(d => d.IdAsistenciaNavigation).WithMany()
                .HasForeignKey(d => d.IdAsistencia)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Asistenci__idAsi__05D8E0BE");

            entity.HasOne(d => d.IdUsuarioNavigation).WithMany()
                .HasForeignKey(d => d.IdUsuario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Asistenci__idUsu__10E07F16");
        });

        modelBuilder.Entity<CentroCosto>(entity =>
        {
            entity.HasKey(e => e.IdCentroCosto).HasName("PK__CentroCo__341DB8FB47A227FB");

            entity.ToTable("CentroCosto");

            entity.Property(e => e.IdCentroCosto).HasColumnName("idCentroCosto");
            entity.Property(e => e.Nombre)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("nombre");
        });

        modelBuilder.Entity<Ciudad>(entity =>
        {
            entity.HasKey(e => e.IdCiudad).HasName("PK__Ciudad__D4D3CCB0D1F29150");

            entity.ToTable("Ciudad");

            entity.Property(e => e.Activo).HasDefaultValue(true);
            entity.Property(e => e.Ciudad1)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("Ciudad");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");

            entity.HasOne(d => d.IdDepartamentoNavigation).WithMany(p => p.Ciudads)
                .HasForeignKey(d => d.IdDepartamento)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Ciudad__IdDepart__7BE56230");
        });

        modelBuilder.Entity<Comuna>(entity =>
        {
            entity.HasKey(e => e.IdComuna);

            entity.ToTable("Comuna");

            entity.Property(e => e.IdComuna).HasColumnName("idComuna");
            entity.Property(e => e.Codigo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("codigo");
            entity.Property(e => e.IdProvincia).HasColumnName("idProvincia");
            entity.Property(e => e.Nombre)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("nombre");
            entity.Property(e => e.RequiereOds).HasColumnName("requiereODS");
        });

        modelBuilder.Entity<Conexion>(entity =>
        {
            entity.HasKey(e => e.IdConexion);

            entity.ToTable("Conexion");

            entity.Property(e => e.IdConexion).HasColumnName("idConexion");
            entity.Property(e => e.Autenticacion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("autenticacion");
            entity.Property(e => e.EsProxy).HasColumnName("esProxy");
            entity.Property(e => e.Fecha)
                .HasColumnType("datetime")
                .HasColumnName("fecha");
            entity.Property(e => e.FechaFinSession)
                .HasColumnType("datetime")
                .HasColumnName("fechaFinSession");
            entity.Property(e => e.Host)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("host");
            entity.Property(e => e.IdSistema).HasColumnName("idSistema");
            entity.Property(e => e.IpCliente)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ipCliente");
            entity.Property(e => e.IpPeticion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ipPeticion");
            entity.Property(e => e.Navegador)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("navegador");
            entity.Property(e => e.SessionId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("sessionId");
            entity.Property(e => e.Usuario)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("usuario");

            entity.HasOne(d => d.IdSistemaNavigation).WithMany(p => p.Conexions)
                .HasForeignKey(d => d.IdSistema)
                .HasConstraintName("FK_Conexion_Sistema");
        });

        modelBuilder.Entity<Contacto>(entity =>
        {
            entity.HasKey(e => e.IdContacto);

            entity.ToTable("Contacto");

            entity.Property(e => e.Activo).HasColumnName("activo");
            entity.Property(e => e.ActualizadoPor)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("actualizadoPor");
            entity.Property(e => e.Ciudad)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ciudad");
            entity.Property(e => e.CodigoPostal)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("codigoPostal");
            entity.Property(e => e.CreadoPor)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("creadoPor");
            entity.Property(e => e.Direccion)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("direccion");
            entity.Property(e => e.FechaActualizacion)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("fechaActualizacion");
            entity.Property(e => e.FechaCreacion)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("fechaCreacion");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nombre");
            entity.Property(e => e.Pais)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("pais");
            entity.Property(e => e.Telefono)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("telefono");
        });

        modelBuilder.Entity<Departamento>(entity =>
        {
            entity.HasKey(e => e.IdDepartamento).HasName("PK__Departam__787A433DA81E97F3");

            entity.ToTable("Departamento");

            entity.Property(e => e.Activo).HasDefaultValue(true);
            entity.Property(e => e.CodigoPostal)
                .HasMaxLength(4)
                .IsUnicode(false);
            entity.Property(e => e.Departamento1)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("Departamento");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");

            entity.HasOne(d => d.IdPaisNavigation).WithMany(p => p.Departamentos)
                .HasForeignKey(d => d.IdPais)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Departame__IdPai__6CA31EA0");
        });

        modelBuilder.Entity<DiccionarioError>(entity =>
        {
            entity.HasKey(e => e.IdDiccionarioError);

            entity.ToTable("DiccionarioError");

            entity.Property(e => e.Descripcion)
                .IsUnicode(false)
                .HasComment("indica el significado del error");
            entity.Property(e => e.MensajeGeneral).IsUnicode(false);

            entity.HasOne(d => d.IdTipoErrorNavigation).WithMany(p => p.DiccionarioErrors)
                .HasForeignKey(d => d.IdTipoError)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DiccionarioError_TipoError");
        });

        modelBuilder.Entity<Distrito>(entity =>
        {
            entity.HasKey(e => e.IdDistrito).HasName("PK__Distrito__DE8EED5997CB6710");

            entity.ToTable("Distrito");

            entity.Property(e => e.Activo).HasDefaultValue(true);
            entity.Property(e => e.CodigoPostal)
                .HasMaxLength(4)
                .IsUnicode(false);
            entity.Property(e => e.Distrito1)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("Distrito");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");

            entity.HasOne(d => d.IdProvinciaNavigation).WithMany(p => p.Distritos)
                .HasForeignKey(d => d.IdProvincia)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Distrito__IdProv__7720AD13");
        });

        modelBuilder.Entity<Empresa>(entity =>
        {
            entity.HasKey(e => e.IdEmpresa);

            entity.ToTable("Empresa");

            entity.Property(e => e.IdEmpresa).HasColumnName("idEmpresa");
            entity.Property(e => e.Ciudad)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ciudad");
            entity.Property(e => e.CodigoSucursal)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("codigoSucursal");
            entity.Property(e => e.Direccion)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("direccion");
            entity.Property(e => e.Estado).HasDefaultValue(true);
            entity.Property(e => e.Fono)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("fono");
            entity.Property(e => e.Giro)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("giro");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nombre");
            entity.Property(e => e.Rut)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("rut");
            entity.Property(e => e.RutaLogo)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("rutaLogo");
        });

        modelBuilder.Entity<ErrorSistema>(entity =>
        {
            entity.HasKey(e => e.IdError).HasName("PK__ErrorSis__C8A4CFD9331B9B9C");

            entity.ToTable("ErrorSistema");

            entity.Property(e => e.FechaError).HasColumnType("datetime");
            entity.Property(e => e.Iphost)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("IPHost");
            entity.Property(e => e.Ipusuario)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("IPUsuario");
            entity.Property(e => e.LoginUsuario)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MensajeError).HasColumnType("ntext");
            entity.Property(e => e.TypeException)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("typeException");
            entity.Property(e => e.Url)
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.HasOne(d => d.IdSistemaNavigation).WithMany(p => p.ErrorSistemas)
                .HasForeignKey(d => d.IdSistema)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ErrorSistema_Sistema");

            entity.HasOne(d => d.IdTipoErrorNavigation).WithMany(p => p.ErrorSistemas)
                .HasForeignKey(d => d.IdTipoError)
                .HasConstraintName("FK_ErrorSistema_TipoError");
        });

        modelBuilder.Entity<ErrorUsuario>(entity =>
        {
            entity.HasKey(e => e.IdErrorUsuario);

            entity.ToTable("ErrorUsuario");

            entity.Property(e => e.IdErrorUsuario)
                .ValueGeneratedNever()
                .HasColumnName("idErrorUsuario");
            entity.Property(e => e.DescripcionUsuario)
                .IsUnicode(false)
                .HasColumnName("descripcionUsuario");
            entity.Property(e => e.FechaError)
                .HasColumnType("datetime")
                .HasColumnName("fechaError");
            entity.Property(e => e.FechaPrimeraRevision)
                .HasColumnType("datetime")
                .HasColumnName("fechaPrimeraRevision");
            entity.Property(e => e.FechaSolucion)
                .HasColumnType("datetime")
                .HasColumnName("fechaSolucion");
            entity.Property(e => e.IdErrorSistema).HasColumnName("idErrorSistema");
            entity.Property(e => e.IdEstadoTicket).HasColumnName("idEstadoTicket");
            entity.Property(e => e.IdSistema).HasColumnName("idSistema");
            entity.Property(e => e.RevisadoPor)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("revisadoPor");
            entity.Property(e => e.Screenshot).HasColumnName("screenshot");
            entity.Property(e => e.Solucion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("solucion");
            entity.Property(e => e.Ticket)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ticket");
            entity.Property(e => e.Usuario)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("usuario");
        });

        modelBuilder.Entity<Hoja1>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Hoja1$");

            entity.Property(e => e.FechaError)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Iphost)
                .HasMaxLength(255)
                .HasColumnName("IPHost");
            entity.Property(e => e.Ipusuario)
                .HasMaxLength(255)
                .HasColumnName("IPUsuario");
            entity.Property(e => e.LoginUsuario).HasMaxLength(255);
            entity.Property(e => e.Url).HasMaxLength(255);
        });

        modelBuilder.Entity<ImpresoraServidor>(entity =>
        {
            entity.HasKey(e => e.IdImpresoraServidor);

            entity.ToTable("ImpresoraServidor");

            entity.Property(e => e.IdImpresoraServidor).HasColumnName("idImpresoraServidor");
            entity.Property(e => e.NombreImpresoraServidor)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nombreImpresoraServidor");
        });

        modelBuilder.Entity<ImpresoraSistema>(entity =>
        {
            entity.HasKey(e => new { e.IdSistema, e.NombreEquipoLocal });

            entity.ToTable("ImpresoraSistema");

            entity.Property(e => e.IdSistema).HasColumnName("idSistema");
            entity.Property(e => e.NombreEquipoLocal)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nombreEquipoLocal");
            entity.Property(e => e.NombreImpresora)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nombreImpresora");
            entity.Property(e => e.Referencia)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("referencia");
        });

        modelBuilder.Entity<Mensaje>(entity =>
        {
            entity.HasKey(e => e.IdMensaje);

            entity.ToTable("Mensaje");

            entity.Property(e => e.IdMensaje).HasColumnName("idMensaje");
            entity.Property(e => e.Habilitado)
                .HasDefaultValue(true)
                .HasColumnName("habilitado");
            entity.Property(e => e.Mensaje1)
                .HasMaxLength(5000)
                .IsUnicode(false)
                .HasColumnName("mensaje");
        });

        modelBuilder.Entity<MensajeUsuario>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("MensajeUsuario");

            entity.Property(e => e.IdMensaje).HasColumnName("idMensaje");
            entity.Property(e => e.IdSistema).HasColumnName("idSistema");
            entity.Property(e => e.IdUsuario).HasColumnName("idUsuario");
            entity.Property(e => e.Mostrar)
                .HasDefaultValue(true)
                .HasColumnName("mostrar");

            entity.HasOne(d => d.IdMensajeNavigation).WithMany()
                .HasForeignKey(d => d.IdMensaje)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MensajeUsuario_Mensaje");

            entity.HasOne(d => d.IdUsuarioNavigation).WithMany()
                .HasForeignKey(d => d.IdUsuario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MensajeUsuario_Usuario");
        });

        modelBuilder.Entity<Menu>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Menu");

            entity.Property(e => e.Descripcion)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("descripcion");
            entity.Property(e => e.DescripcionIngles)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Habilitado).HasColumnName("habilitado");
            entity.Property(e => e.Icono)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("icono");
            entity.Property(e => e.IdSistema).HasColumnName("idSistema");
            entity.Property(e => e.MenuId).HasColumnName("menuId");
            entity.Property(e => e.PadreId).HasColumnName("padreId");
            entity.Property(e => e.Pagina)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("pagina");
            entity.Property(e => e.Parametros)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("parametros");
            entity.Property(e => e.Posicion).HasColumnName("posicion");
            entity.Property(e => e.Ruta)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("ruta");

            entity.HasOne(d => d.IdSistemaNavigation).WithMany()
                .HasForeignKey(d => d.IdSistema)
                .HasConstraintName("FK_Menu_Sistema");
        });

        modelBuilder.Entity<MenuReporte>(entity =>
        {
            entity.HasKey(e => e.IdMenu);

            entity.Property(e => e.IdMenu)
                .ValueGeneratedNever()
                .HasColumnName("idMenu");
            entity.Property(e => e.CodigoMenu)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("codigoMenu");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("descripcion");
            entity.Property(e => e.Habilitado)
                .HasDefaultValue(true)
                .HasColumnName("habilitado");
            entity.Property(e => e.Icono)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("icono");
            entity.Property(e => e.IdPadre).HasColumnName("idPadre");
            entity.Property(e => e.Pagina)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("pagina");
            entity.Property(e => e.Posicion).HasColumnName("posicion");
            entity.Property(e => e.RutaInforme)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("rutaInforme");
        });

        modelBuilder.Entity<Operador>(entity =>
        {
            entity.HasKey(e => e.IdOperador);

            entity.ToTable("Operador");

            entity.Property(e => e.IdOperador).HasColumnName("idOperador");
            entity.Property(e => e.CodigoOperador)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("codigoOperador");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("descripcion");
        });

        modelBuilder.Entity<OperadorSistema>(entity =>
        {
            entity.HasKey(e => new { e.IdOperador, e.IdSistema });

            entity.ToTable("OperadorSistema");

            entity.Property(e => e.IdOperador).HasColumnName("idOperador");
            entity.Property(e => e.IdSistema).HasColumnName("idSistema");
        });

        modelBuilder.Entity<Pai>(entity =>
        {
            entity.HasKey(e => e.IdPais).HasName("PK__Pais__FC850A7B99DF64EB");

            entity.Property(e => e.IdPais).ValueGeneratedNever();
            entity.Property(e => e.Activo).HasDefaultValue(true);
            entity.Property(e => e.CodigoAlfa2)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.CorreoSoporte)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Folder)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.HorarioAtencion)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Inicio).HasDefaultValue(false);
            entity.Property(e => e.Pais)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.RutaImagen)
                .HasMaxLength(60)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Permiso>(entity =>
        {
            entity.HasKey(e => e.IdPermiso);

            entity.ToTable("Permiso");

            entity.Property(e => e.IdPermiso).HasColumnName("idPermiso");
            entity.Property(e => e.IdSistema).HasColumnName("idSistema");
            entity.Property(e => e.NombreElemento)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nombreElemento");
            entity.Property(e => e.TipoPermiso)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("tipoPermiso");
        });

        modelBuilder.Entity<Provincium>(entity =>
        {
            entity.HasKey(e => e.IdProvincia).HasName("PK__Provinci__EED7445520A9FA3E");

            entity.Property(e => e.Activo).HasDefaultValue(true);
            entity.Property(e => e.CodigoPostal)
                .HasMaxLength(4)
                .IsUnicode(false);
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Provincia)
                .HasMaxLength(60)
                .IsUnicode(false);

            entity.HasOne(d => d.IdDepartamentoNavigation).WithMany(p => p.Provincia)
                .HasForeignKey(d => d.IdDepartamento)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Provincia__IdDep__725BF7F6");
        });

        modelBuilder.Entity<Rol>(entity =>
        {
            entity.HasKey(e => e.IdRol);

            entity.ToTable("Rol");

            entity.Property(e => e.IdRol).HasColumnName("idRol");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("descripcion");
            entity.Property(e => e.IdSistema).HasColumnName("idSistema");

            entity.HasOne(d => d.IdSistemaNavigation).WithMany(p => p.Rols)
                .HasForeignKey(d => d.IdSistema)
                .HasConstraintName("FK_Rol_Sistema");

            entity.HasMany(d => d.IdPermisos).WithMany(p => p.IdRols)
                .UsingEntity<Dictionary<string, object>>(
                    "RolPermiso",
                    r => r.HasOne<Permiso>().WithMany()
                        .HasForeignKey("IdPermiso")
                        .HasConstraintName("FK_RolPermiso_Permiso"),
                    l => l.HasOne<Rol>().WithMany()
                        .HasForeignKey("IdRol")
                        .HasConstraintName("FK_RolPermiso_Rol"),
                    j =>
                    {
                        j.HasKey("IdRol", "IdPermiso");
                        j.ToTable("RolPermiso");
                        j.IndexerProperty<int>("IdRol").HasColumnName("idRol");
                        j.IndexerProperty<int>("IdPermiso").HasColumnName("idPermiso");
                    });
        });

        modelBuilder.Entity<RolSucursal>(entity =>
        {
            entity.HasKey(e => e.IdRolSucursal).HasName("PK__RolSucur__DBC415F9F9652137");

            entity.ToTable("RolSucursal");

            entity.HasOne(d => d.IdRolNavigation).WithMany(p => p.RolSucursals)
                .HasForeignKey(d => d.IdRol)
                .HasConstraintName("Fk_Rol_RolSucursal");
        });

        modelBuilder.Entity<Sistema>(entity =>
        {
            entity.HasKey(e => e.IdSistema);

            entity.ToTable("Sistema");

            entity.Property(e => e.IdSistema).HasColumnName("idSistema");
            entity.Property(e => e.Logo)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("logo");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nombre");
        });

        modelBuilder.Entity<SistemaEmpresa>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SistemaEmpresa");

            entity.Property(e => e.IdEmpresa).HasColumnName("idEmpresa");
            entity.Property(e => e.IdSistema).HasColumnName("idSistema");
        });

        modelBuilder.Entity<SucTmpEntel>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SucTmpEntel");

            entity.Property(e => e.Bod)
                .HasMaxLength(255)
                .HasColumnName("BOD");
            entity.Property(e => e.Cod).HasColumnName("COD");
            entity.Property(e => e.MailJoc)
                .HasMaxLength(255)
                .HasColumnName("MAIL JOC");
            entity.Property(e => e.NombreTienda)
                .HasMaxLength(255)
                .HasColumnName("NOMBRE TIENDA");
        });

        modelBuilder.Entity<SucursalTemp>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SucursalTemp");

            entity.Property(e => e.Ciudad)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("ciudad");
            entity.Property(e => e.CodigoSucursal)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("codigoSucursal");
            entity.Property(e => e.Direccion)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("direccion");
            entity.Property(e => e.IdSucursal).HasColumnName("idSucursal");
            entity.Property(e => e.Nombre)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("nombre");
            entity.Property(e => e.RutSucursal)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("rutSucursal");
        });

        modelBuilder.Entity<TableSize>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.Data)
                .HasMaxLength(18)
                .IsUnicode(false)
                .HasColumnName("data");
            entity.Property(e => e.IndexSize)
                .HasMaxLength(18)
                .IsUnicode(false)
                .HasColumnName("index_size");
            entity.Property(e => e.Name)
                .HasMaxLength(128)
                .HasColumnName("name");
            entity.Property(e => e.Reserved)
                .HasMaxLength(18)
                .IsUnicode(false)
                .HasColumnName("reserved");
            entity.Property(e => e.Rows)
                .HasMaxLength(11)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("rows");
            entity.Property(e => e.Unused)
                .HasMaxLength(18)
                .IsUnicode(false)
                .HasColumnName("unused");
        });

        modelBuilder.Entity<TblEstadoTarea>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblEstadoTarea");

            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("descripcion");
            entity.Property(e => e.IdEstadoTarea)
                .ValueGeneratedOnAdd()
                .HasColumnName("idEstadoTarea");
        });

        modelBuilder.Entity<TblTarea>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblTarea");

            entity.Property(e => e.AsignadaA)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("asignadaA");
            entity.Property(e => e.DescripcionTarea)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("descripcionTarea");
            entity.Property(e => e.FechaInicioTarea)
                .HasColumnType("datetime")
                .HasColumnName("fechaInicioTarea");
            entity.Property(e => e.FechaSolicitud)
                .HasColumnType("datetime")
                .HasColumnName("fechaSolicitud");
            entity.Property(e => e.FechaTerminoTarea)
                .HasColumnType("datetime")
                .HasColumnName("fechaTerminoTarea");
            entity.Property(e => e.IdEstadoTarea).HasColumnName("idEstadoTarea");
            entity.Property(e => e.IdTarea)
                .ValueGeneratedOnAdd()
                .HasColumnName("idTarea");
            entity.Property(e => e.IdTipoTarea).HasColumnName("idTipoTarea");
            entity.Property(e => e.NombreTarea)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("nombreTarea");
            entity.Property(e => e.Solicitante)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("solicitante");
        });

        modelBuilder.Entity<TblTipoTarea>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblTipoTarea");

            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("descripcion");
            entity.Property(e => e.IdTipoTarea)
                .ValueGeneratedOnAdd()
                .HasColumnName("idTipoTarea");
        });

        modelBuilder.Entity<Tiendum>(entity =>
        {
            entity.HasKey(e => e.IdTienda);

            entity.HasIndex(e => e.Codigo, "Tienda_Unique_Codigo").IsUnique();

            entity.Property(e => e.IdTienda).HasColumnName("idTienda");
            entity.Property(e => e.Activa)
                .HasDefaultValue(true)
                .HasColumnName("activa");
            entity.Property(e => e.ActualizadaPor)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("actualizadaPor");
            entity.Property(e => e.Codigo)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("codigo");
            entity.Property(e => e.CreadaPor)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("creadaPor");
            entity.Property(e => e.FechaActualizacion)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("fechaActualizacion");
            entity.Property(e => e.FechaCreacion)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("fechaCreacion");
            entity.Property(e => e.IdContacto).HasColumnName("idContacto");
            entity.Property(e => e.IdEmpresa).HasColumnName("idEmpresa");
            entity.Property(e => e.IdSistema).HasColumnName("idSistema");
            entity.Property(e => e.Nombre)
                .HasMaxLength(75)
                .IsUnicode(false)
                .HasColumnName("nombre");
        });

        modelBuilder.Entity<TipoError>(entity =>
        {
            entity.HasKey(e => e.IdTipoError);

            entity.ToTable("TipoError");

            entity.Property(e => e.Descripcion)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ToolTipMensaje>(entity =>
        {
            entity.HasKey(e => e.IdToolTipMensaje);

            entity.ToTable("ToolTipMensaje");

            entity.Property(e => e.IdToolTipMensaje).HasColumnName("idToolTipMensaje");
            entity.Property(e => e.ControlId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("controlId");
            entity.Property(e => e.Habilitado).HasColumnName("habilitado");
            entity.Property(e => e.Mensaje)
                .HasMaxLength(2000)
                .IsUnicode(false)
                .HasColumnName("mensaje");
            entity.Property(e => e.Pagina)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("pagina");
            entity.Property(e => e.Posicion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("posicion");
        });

        modelBuilder.Entity<ToolTipMensajeUsuario>(entity =>
        {
            entity.HasKey(e => e.IdToolTipMensajeUsuario);

            entity.ToTable("ToolTipMensajeUsuario");

            entity.Property(e => e.IdToolTipMensajeUsuario).HasColumnName("idToolTipMensajeUsuario");
            entity.Property(e => e.Habilitado)
                .HasDefaultValue(true)
                .HasColumnName("habilitado");
            entity.Property(e => e.IdSistema).HasColumnName("idSistema");
            entity.Property(e => e.IdToolTipMensaje).HasColumnName("idToolTipMensaje");
            entity.Property(e => e.IdUsuario).HasColumnName("idUsuario");
        });

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(e => e.IdUsuario);

            entity.ToTable("Usuario");

            entity.HasIndex(e => e.Login, "IX_login").IsUnique();

            entity.Property(e => e.IdUsuario).HasColumnName("idUsuario");
            entity.Property(e => e.Activo)
                .HasDefaultValue(true)
                .HasColumnName("activo");
            entity.Property(e => e.Cedula)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CentroCosto).HasColumnName("centroCosto");
            entity.Property(e => e.Dv)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("dv");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.EmailPivot)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("emailPivot");
            entity.Property(e => e.EsUsuarioFinal).HasColumnName("esUsuarioFinal");
            entity.Property(e => e.FechaIngreso)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("fechaIngreso");
            entity.Property(e => e.Login)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("login");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nombre");
            entity.Property(e => e.Password)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("password");
            entity.Property(e => e.PasswordProvisorio)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("((1))")
                .HasColumnName("passwordProvisorio");
            entity.Property(e => e.PuedeResetearClave)
                .HasDefaultValue(true)
                .HasColumnName("puedeResetearClave");
            entity.Property(e => e.Rut).HasColumnName("rut");
            entity.Property(e => e.RutaFirma)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Sucursal).HasColumnName("sucursal");
            entity.Property(e => e.TechId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Telefono)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("telefono");
            entity.Property(e => e.Telefono2)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("telefono2");
            entity.Property(e => e.UsuarioInterno).HasColumnName("usuarioInterno");

            entity.HasOne(d => d.CentroCostoNavigation).WithMany(p => p.Usuarios)
                .HasForeignKey(d => d.CentroCosto)
                .HasConstraintName("FK__Usuario__centroC__15A53433");

            entity.HasMany(d => d.IdEmpresas).WithMany(p => p.IdUsuarios)
                .UsingEntity<Dictionary<string, object>>(
                    "UsuarioEmpresa",
                    r => r.HasOne<Empresa>().WithMany()
                        .HasForeignKey("IdEmpresa")
                        .HasConstraintName("FK_UsuarioEmpresa_Empresa"),
                    l => l.HasOne<Usuario>().WithMany()
                        .HasForeignKey("IdUsuario")
                        .HasConstraintName("FK_UsuarioEmpresa_Usuario"),
                    j =>
                    {
                        j.HasKey("IdUsuario", "IdEmpresa");
                        j.ToTable("UsuarioEmpresa");
                        j.IndexerProperty<int>("IdUsuario").HasColumnName("idUsuario");
                        j.IndexerProperty<int>("IdEmpresa").HasColumnName("idEmpresa");
                    });

            entity.HasMany(d => d.IdRols).WithMany(p => p.Idusuarios)
                .UsingEntity<Dictionary<string, object>>(
                    "UsuarioRol",
                    r => r.HasOne<Rol>().WithMany()
                        .HasForeignKey("IdRol")
                        .HasConstraintName("FK_UsuarioRol_Rol"),
                    l => l.HasOne<Usuario>().WithMany()
                        .HasForeignKey("Idusuario")
                        .HasConstraintName("FK_UsuarioRol_Usuario"),
                    j =>
                    {
                        j.HasKey("Idusuario", "IdRol");
                        j.ToTable("UsuarioRol");
                        j.IndexerProperty<int>("Idusuario").HasColumnName("idusuario");
                        j.IndexerProperty<int>("IdRol").HasColumnName("idRol");
                    });

            entity.HasMany(d => d.IdUsuarioSupervisors).WithMany(p => p.IdUsuarios)
                .UsingEntity<Dictionary<string, object>>(
                    "UsuarioSupervisor",
                    r => r.HasOne<Usuario>().WithMany()
                        .HasForeignKey("IdUsuarioSupervisor")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_UsuarioSupervisor_Usuario1"),
                    l => l.HasOne<Usuario>().WithMany()
                        .HasForeignKey("IdUsuario")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_UsuarioSupervisor_Usuario"),
                    j =>
                    {
                        j.HasKey("IdUsuario", "IdUsuarioSupervisor");
                        j.ToTable("UsuarioSupervisor");
                        j.IndexerProperty<int>("IdUsuario").HasColumnName("idUsuario");
                        j.IndexerProperty<int>("IdUsuarioSupervisor").HasColumnName("idUsuarioSupervisor");
                    });

            entity.HasMany(d => d.IdUsuarios).WithMany(p => p.IdUsuarioSupervisors)
                .UsingEntity<Dictionary<string, object>>(
                    "UsuarioSupervisor",
                    r => r.HasOne<Usuario>().WithMany()
                        .HasForeignKey("IdUsuario")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_UsuarioSupervisor_Usuario"),
                    l => l.HasOne<Usuario>().WithMany()
                        .HasForeignKey("IdUsuarioSupervisor")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_UsuarioSupervisor_Usuario1"),
                    j =>
                    {
                        j.HasKey("IdUsuario", "IdUsuarioSupervisor");
                        j.ToTable("UsuarioSupervisor");
                        j.IndexerProperty<int>("IdUsuario").HasColumnName("idUsuario");
                        j.IndexerProperty<int>("IdUsuarioSupervisor").HasColumnName("idUsuarioSupervisor");
                    });
        });

        modelBuilder.Entity<UsuarioAnovo>(entity =>
        {
            entity.HasKey(e => e.IdUsuarioAnovo);

            entity.ToTable("UsuarioAnovo");

            entity.Property(e => e.IdUsuarioAnovo).HasColumnName("idUsuarioAnovo");
            entity.Property(e => e.Login)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("login");
            entity.Property(e => e.Password)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("password");
            entity.Property(e => e.Vigente).HasColumnName("vigente");
        });

        modelBuilder.Entity<UsuarioMenu>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("USUARIO_MENU");

            entity.Property(e => e.Estado).HasDefaultValue(true);
        });

        modelBuilder.Entity<UsuarioPai>(entity =>
        {
            entity.HasKey(e => e.IdUsuarioPais).HasName("PK__UsuarioP__470D84CE493BE32F");

            entity.Property(e => e.Activo).HasDefaultValue(true);
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");

            entity.HasOne(d => d.IdPaisNavigation).WithMany(p => p.UsuarioPais)
                .HasForeignKey(d => d.IdPais)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__UsuarioPa__IdPai__019E3B86");

            entity.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.UsuarioPais)
                .HasForeignKey(d => d.IdUsuario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__UsuarioPa__IdUsu__00AA174D");
        });

        modelBuilder.Entity<UsuarioSistema>(entity =>
        {
            entity.HasKey(e => new { e.IdUsuario, e.IdSistema });

            entity.ToTable("UsuarioSistema");

            entity.Property(e => e.IdUsuario).HasColumnName("idUsuario");
            entity.Property(e => e.IdSistema).HasColumnName("idSistema");
            entity.Property(e => e.Conectado).HasColumnName("conectado");
            entity.Property(e => e.EsSupervisor).HasColumnName("esSupervisor");
            entity.Property(e => e.FechaConeccion)
                .HasColumnType("datetime")
                .HasColumnName("fechaConeccion");

            entity.HasOne(d => d.IdSistemaNavigation).WithMany(p => p.UsuarioSistemas)
                .HasForeignKey(d => d.IdSistema)
                .HasConstraintName("FK_UsuarioSistema_Sistema");

            entity.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.UsuarioSistemas)
                .HasForeignKey(d => d.IdUsuario)
                .HasConstraintName("FK_UsuarioSistema_Usuario");
        });

        modelBuilder.Entity<UsuarioSistemaSupervisor>(entity =>
        {
            entity.HasKey(e => new { e.IdSistema, e.IdUsuarioSupervisor, e.IdUsuario });

            entity.ToTable("UsuarioSistemaSupervisor");

            entity.Property(e => e.IdSistema).HasColumnName("idSistema");
            entity.Property(e => e.IdUsuarioSupervisor).HasColumnName("idUsuarioSupervisor");
            entity.Property(e => e.IdUsuario).HasColumnName("idUsuario");

            entity.HasOne(d => d.UsuarioSistema).WithMany(p => p.UsuarioSistemaSupervisors)
                .HasForeignKey(d => new { d.IdUsuario, d.IdSistema })
                .HasConstraintName("FK_UsuarioSistemaSupervisor_UsuarioSistema");
        });

        modelBuilder.Entity<UsuarioTiendum>(entity =>
        {
            entity.HasKey(e => new { e.IdTienda, e.IdUsuario });

            entity.Property(e => e.IdTienda).HasColumnName("idTienda");
            entity.Property(e => e.IdUsuario).HasColumnName("idUsuario");
            entity.Property(e => e.FechaCreacion)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("fechaCreacion");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
