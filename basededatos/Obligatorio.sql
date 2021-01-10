
use master
go

if exists(Select * FROM SysDataBases WHERE name='Obligatorio')
BEGIN
	DROP DATABASE Obligatorio
END
go

CREATE DATABASE Obligatorio
ON(
	NAME=Obligatorio,
	FILENAME='c:\Obligatorio.mdf'
)
go


USE Obligatorio
go

CREATE TABLE Aeropuertos(
	CodAero varchar(3) NOT NULL PRIMARY KEY check(CodAero like '[A-Z][A-Z][A-Z]' ),
	NomAero varchar(20) NOT NULL check(len(NomAero)<20),
	Ciudad varchar(20)check(len(Ciudad)<20),
	Baja bit not null default 0
) 
go
CREATE TABLE Lineas(
	SiglaLinea varchar(20) NOT NULL PRIMARY KEY check(len(SiglaLinea)<20) ,
	Direccion varchar(20) NOT NULL check(len(Direccion)<20),
	Bajados bit not null default 0
	
) 
go
CREATE TABLE TelLineas(
	SiglaLinea varchar(20) not null Foreign Key References Lineas(SiglaLinea),
	NumTel varchar(20) not null check(len(NumTel)<20),
	Primary Key (SiglaLinea, NumTel)
	
) 
go
CREATE TABLE Vuelos(
	CodVuelo varchar(18) NOT NULL PRIMARY KEY check( Codvuelo like 
	'[A-Z][A-Z][A-Z][A-Z][A-Z][A-Z][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]'),	
	Asientos int NOT NULL check(Asientos>0),
	FechaHora datetime not null  ,
	SiglaLinea varchar(20)  not Null Foreign Key References Lineas(SiglaLinea),
	Aeropuertosalida varchar(3)  not NULL Foreign Key References Aeropuertos(CodAero),
	
	Aeropuertollegada varchar(3) not NULL Foreign Key References Aeropuertos(CodAero),
	
	


) 
go
CREATE TABLE Usuarios(
	Ndoc int NOT NULL PRIMARY KEY ,
	NomUsuario varchar(20) NOT NULL check(len(NomUsuario)<20) ,
	Usuario varchar(20) NOT NULL unique check(len(Usuario)<20),
	Constraseña varchar(8) not null check(len(Constraseña) = 8),

	
) 
go
Create Table Clientes
(
	Ndoc int Not Null Primary Key Foreign Key References Usuarios(Ndoc),
	Targeta bigint Not Null check(len(Targeta) = 16)
)
go
Create Table Administradores
(
	Ndoc int Not Null Primary Key Foreign Key References Usuarios(Ndoc),
	GenVuelos bit 
)
go

CREATE TABLE Reservas(
   NAsiento int not null check(NAsiento>0 ),
	CodVuelo varchar(18) not null Foreign Key References Vuelos(CodVuelo),
	Ndoc int not null Foreign Key References Clientes(Ndoc),
primary key(CodVuelo,Ndoc)
) 
go

Insert Aeropuertos(CodAero,NomAero,Ciudad) Values ('MPB','Aeropuertouno','Miami')
Insert Aeropuertos(CodAero,NomAero,Ciudad) Values ('UAQ','Aeropuertodos','SanJuan')
Insert Aeropuertos(CodAero,NomAero,Ciudad) Values ('UIN','Aeropuertotres','Quincy')
Insert Aeropuertos(CodAero,NomAero,Ciudad) Values ('ALP','Aeropuertocuatro','Alepo')
Insert Aeropuertos(CodAero,NomAero,Ciudad) Values ('DKR','Aeropuertocinco','Dakar')
Insert Aeropuertos(CodAero,NomAero,Ciudad) Values ('MDR','Aeropuertoseis','Montevideo')
go

Insert Lineas(SiglaLinea,Direccion) Values ('Avianca','Direccionuno')
Insert Lineas(SiglaLinea,Direccion) Values ('Jetairfly','Direcciondos')
Insert Lineas(SiglaLinea,Direccion) Values ('Aeromar','Direcciontres')
Insert Lineas(SiglaLinea,Direccion) Values ('Wideroe','Direccioncuatro')
Insert Lineas(SiglaLinea,Direccion) Values ('Zestair','Direccioncinco')
go
Insert TelLineas(SiglaLinea,NumTel) Values ('Avianca','099999999')
Insert TelLineas(SiglaLinea,NumTel) Values ('Jetairfly','088888888')
Insert TelLineas(SiglaLinea,NumTel) Values ('Jetairfly','077777777')
Insert TelLineas(SiglaLinea,NumTel) Values ('Aeromar','066666666')
Insert TelLineas(SiglaLinea,NumTel) Values ('Aeromar','055555555')
Insert TelLineas(SiglaLinea,NumTel) Values ('Aeromar','044444444')
Insert TelLineas(SiglaLinea,NumTel) Values ('Wideroe','033333333')
Insert TelLineas(SiglaLinea,NumTel) Values ('Zestair','022222222')
go


insert Vuelos(CodVuelo,SiglaLinea,Asientos,FechaHora,Aeropuertosalida,Aeropuertollegada) values ('MPBUAQ201612101200','Avianca',40,'10/12/2016 12:00','MPB','UAQ')
insert Vuelos(CodVuelo,SiglaLinea,Asientos,FechaHora,Aeropuertosalida,Aeropuertollegada) values ('UAQUIN201612111300','Aeromar',35,'11/12/2016 13:00','UAQ','UIN')
insert Vuelos(CodVuelo,SiglaLinea,Asientos,FechaHora,Aeropuertosalida,Aeropuertollegada) values ('UINALP201612121400','Wideroe',30,'12/12/2016 14:00','UIN','ALP')
insert Vuelos(CodVuelo,SiglaLinea,Asientos,FechaHora,Aeropuertosalida,Aeropuertollegada) values ('ALPDKR201612131500','Zestair',25,'13/12/2016 15:00','ALP','DKR')
insert Vuelos(CodVuelo,SiglaLinea,Asientos,FechaHora,Aeropuertosalida,Aeropuertollegada) values ('DKRMPB201612281600','Avianca',50,'28/12/2016 16:00','DKR','MPB')

GO
Insert Usuarios(Ndoc,NomUsuario,Usuario,Constraseña) Values (11111,'Usuariouno','Usuuno','Usuariou')
Insert Usuarios(Ndoc,NomUsuario,Usuario,Constraseña) Values (22222,'Usuariodos','Usudos','Usuariod')
Insert Usuarios(Ndoc,NomUsuario,Usuario,Constraseña) Values (33333,'Usuariotres','Usutres','Usuariot')
Insert Usuarios(Ndoc,NomUsuario,Usuario,Constraseña) Values (44444,'Usuariocuatro','Usucuatro','Usuarioc')
Insert Usuarios(Ndoc,NomUsuario,Usuario,Constraseña) Values (55555,'Usuariocinco','Usucinco','Usuarioc')
Insert Usuarios(Ndoc,NomUsuario,Usuario,Constraseña) Values (66666,'Usuarioseis','Ususeis','Usuarios')
Insert Usuarios(Ndoc,NomUsuario,Usuario,Constraseña) Values (77777,'Usuariosiete','Ususiete','Usuarios')
go
insert Clientes(Ndoc,Targeta) values(11111,1111111111111111)
insert Clientes(Ndoc,Targeta) values(33333,2222222222222222)
insert Clientes(Ndoc,Targeta) values(55555,3333333333333333)
insert Clientes(Ndoc,Targeta) values(66666,4444444444444444)
insert Clientes(Ndoc,Targeta) values(77777,5555555555555555)

go
insert Administradores(Ndoc,GenVuelos) values(22222,1)
insert Administradores(Ndoc,GenVuelos) values(44444,0)

go
insert Reservas(CodVuelo,Ndoc,NAsiento) values ('MPBUAQ201612101200',11111,41)
insert Reservas(CodVuelo,Ndoc,NAsiento) values ('UAQUIN201612111300',33333,36)
insert Reservas(CodVuelo,Ndoc,NAsiento) values ('UINALP201612121400',55555,32)
insert Reservas(CodVuelo,Ndoc,NAsiento) values ('UINALP201612121400',11111,31)

go

--PROCEDIMIENTOS--------------------------------------------------------------------------------

------------------------------------------AEROPUERTOS---------------------------
--ALTA AEROPUERTO
Create Procedure AltaAeropuerto @codaero varchar(3), @nomaero varchar(20),@ciudad varchar(20) As
Begin
if (exists(select * from Aeropuertos where CodAero = @codaero and Baja=0))
	begin
		return -1
	end
	if exists(select * from Aeropuertos where CodAero=@codaero and Baja=1)
	begin
	Update Aeropuertos set NomAero=@Nomaero,Ciudad=@ciudad,Baja=0
		where CodAero=@codaero
		return 3
	end
		else
			begin
		Insert Aeropuertos(CodAero,NomAero,Ciudad) values (@codaero , @nomaero,@ciudad)
		if(@@error=0)
			return 1
		else
			return -2
	end		
	
			
End
go

----BAJA AEROPUERTO
create Procedure BajaAeropuerto @codaero varchar(3) AS
Begin
	if not exists(select * from Aeropuertos where CodAero = @codaero and Baja=0)
	BEGIN
		return -1
	END
	if exists(select * from Vuelos where Aeropuertosalida=@codaero or Aeropuertollegada=@codaero )
	begin
		
	 Update Aeropuertos set Baja=1
		where CodAero=@codaero
	end
	else
	
	begin
	delete from Aeropuertos
		where CodAero=@codaero
		if(@@error=0)
			return 1
		else
			return -2	
	end
end
go

----UPDATE AEROPUERTO

create Procedure ModificarAeropuerto @codaero varchar(3),@Nomaero varchar(20),@ciudad varchar(20) AS
Begin
	if not exists(select * from Aeropuertos where CodAero = @codaero and Baja=0)
	BEGIN
		return -1
	END
	else
		begin
			update Aeropuertos set NomAero=@Nomaero,Ciudad=@ciudad where CodAero=@codaero
			If (@@ERROR = 0)
					return 1
				Else
					return -2
			End
		end
	
	

go
-----BUSCO AEROPUERTOS---------------------------------
CREATE Procedure BuscarAeropuerto @Codaero varchar(3) As
Begin
		
	Select * From Aeropuertos where CodAero=@Codaero AND Baja=0
End
go
---------------------------------
--LISTO AEROPUERTOS
CREATE PROCEDURE ListarAeropuertos as
begin
select * from Aeropuertos where Baja=0
end
go


----------------------------------LINEAS AEREAS------------------------------------
--ALTAS LINEAS
Create Procedure AltaLineas @sigla varchar(20), @direccion varchar(20) As
Begin
if (exists(select * from Lineas where SiglaLinea=@sigla and Bajados=0))
	begin
		return -1
	end
	if exists( select * from Lineas
	 where SiglaLinea=@sigla and Bajados=1)
	 begin
	Update Lineas set Direccion=@direccion,Bajados=0
		where SiglaLinea=@sigla
		return 3
	end
		
		
	
		Insert Lineas(SiglaLinea,Direccion) values (@sigla , @direccion)
		if(@@error=0)
			return 1
		else
			return -2
			
End
go
----------------------------------------------------------
--ELIMINAR LINEAS
create Procedure BajaLineas @sigla varchar(20) AS
Begin
	if not exists(select * from Lineas where SiglaLinea = @sigla and Bajados=0)
	BEGIN
		return -1
	END
	if exists(select * from Vuelos where Vuelos.SiglaLinea=@sigla) --or TelLineas.SiglaLinea=@sigla  )
	begin
		
		
	 Update Lineas set Bajados=1
		where SiglaLinea=@sigla
	
	end
	
	--if(  exists(select * from Lineas where Bajados=0))
	else
	begin
		begin transaction
		delete from TelLineas where SiglaLinea=@sigla
		  if @@ERROR <>0
	begin
	rollback tran
	return -1
	end
	
		Delete From Lineas where SiglaLinea=@sigla
		  if @@ERROR <>0
	begin
	rollback tran
	return -1
	end
		commit tran
		return 1			
	end
end
go

---------------------------------
--MODIFICAR LINEAS
create Procedure ModificarLineas  @sigla varchar(20),@direccion varchar(20) As
Begin
		if (Not Exists(Select * From Lineas Where  SiglaLinea = @sigla and Bajados=0))
			Begin
				return -1
			end
		
		
			 
			Begin
				Update Lineas Set  Direccion=@direccion Where SiglaLinea = @sigla 
				If (@@ERROR = 0)
					return 1
				Else
					return -2
			End
			
				
End
go
------
--BUSCAR LINEAS
create Procedure BuscarLineas @sigla varchar(20) As
Begin
		
	Select * From Lineas where SiglaLinea=@sigla and Bajados=0
End
go
--BUSCO LINEAS SIN BAJA LOGICA
create Procedure BuscarLineassinbajalogica @sigla varchar(20) As
Begin
		
	Select * From Lineas where SiglaLinea=@sigla 
End
go
--LISTO LINEAS
create Procedure ListoLineas  As
Begin
		
	Select * From Lineas where Bajados=0
End
go
-----------------------TELEFONOS LINEAS---------------------------------------
--ALTA TELEFONOS LINEAS
Create Procedure AltaTelefono @sigla varchar(20), @NumTel varchar(10) As
Begin
		If Not (Exists(select * from Lineas where SiglaLinea = @sigla and Bajados=0))
			return -1
		if exists(select * from TelLineas where NumTel=@NumTel)
			return -2
		Insert TelLineas(SiglaLinea, NumTel) Values (@sigla, @NumTel)
		
		If @@ERROR = 0
			return 1
		else
			return -2

End
go
--ELIMINO TELEFONO LINEAS
Create Procedure EliminoTelsDeLinea @sigla varchar(20) As
begin
if not exists( select * from Lineas where SiglaLinea=@sigla and Bajados=0)
	begin
	return -1
	end
	else
Begin
	Delete From TelLineas Where SiglaLinea = @sigla 
	if(@@error=0)
			return 1
		else
			return -2
End
end
go
--BUSCO TELEFONOS LINEAS
create Procedure TelefonoDeUnaLinea @sigla varchar(20) As
Begin

	Select * 
	From Lineas L Inner Join TelLineas T on L.SiglaLinea = T.SiglaLinea
	where t.SiglaLinea=@sigla and L.Bajados=0
end
go
---LISTO TELEFONOS DE LINEA
create Procedure ListadoTelefonosLinea @sigla varchar(20) AS
Begin
	Select * 
	From TelLineas 
	Where SiglaLinea=@sigla
End
go
-----------------------------------------------VUELOS-------------------------------------------
--ALTA VUELOS
create PROC AltaVuelos @codvuelo varchar(18)
,@asientos int,@fechahora datetime,@sigla varchar(20) 
,@aerosalida varchar(3),@aerodllegada varchar(3) as
begin
	if exists (select * from Vuelos where CodVuelo=@codvuelo )
		begin
			return -1
		end
	if not exists(select * from Lineas where SiglaLinea=@sigla and Bajados=0)
		begin
			return -2
		end
		if (DATEADD(MINUTE,-120,@fechahora)<GETDATE())
		begin
			return -5
		end
		
	if not exists(select * from Aeropuertos where CodAero=@aerosalida and Baja=0)
		begin
			return -3
		end
	if not exists(select * from Aeropuertos where CodAero=@aerodllegada and Baja=0)
		begin
			return -4
		end
		
		
	
	
		else
		begin
			insert Vuelos(CodVuelo,Asientos,FechaHora,SiglaLinea,Aeropuertosalida,Aeropuertollegada) 
			values (@codvuelo,@asientos,@fechahora,@sigla,@aerosalida,@aerodllegada)
			If (@@ERROR = 0)
			return 1
		else
			return 0
		end
	
	end
	go
----UPDATE VUELOS

create PROC ModificarVuelos @codvuelo varchar(18)
,@asientos int,@sigla varchar(20) 
 as
Begin
	if not exists(select * from Vuelos where CodVuelo = @codvuelo)
	BEGIN
		return -1
	END
	if not exists(select * from Lineas where SiglaLinea=@sigla and Bajados=0)
		begin
			return -2
		end
	
	if exists ( select * from Reservas where CodVuelo=@codvuelo)
		begin
		return -5
		end
		
	
	begin
	
		update Vuelos set  Asientos=@asientos,SiglaLinea=@sigla
		 where CodVuelo=@codvuelo
		
		if(@@error=0)
			return 1
		else
			return -2		
	end
end
go

----ELIMINAR VUELOS
GO
create Procedure BajaVuelos @codvuelo varchar(18) AS
Begin
	if not exists(select * from Vuelos where CodVuelo = @codvuelo)
	BEGIN
		return -1
	END
	if exists ( select * from Reservas where CodVuelo=@codvuelo)
		begin
		return -2
		end
	
	begin
	
		Delete From Vuelos where CodVuelo=@codvuelo 
		
		if(@@error=0)
			return 1
		else
			return -3	
	end
end
go



-------------BUSCO VUELOS---------
create Procedure BuscoVuelos @codvuelo varchar(18) As
Begin
		select * from Vuelos where CodVuelo=@codvuelo 
	
End
go
---------------LISTO VUELOS------------
create Procedure ListoVuelos As
Begin
		select  * from Vuelos 
End
go

-------------------------------------------------------USUARIOS-------------------------------
---ELIMINAR ADMINISTRADOR---
Create Procedure BajaAdmin @Ndoc int As
Begin
		if (not Exists(Select * From Administradores Where Ndoc = @Ndoc))
				return -1

		Begin Transaction
		
		Delete From Administradores Where Ndoc = @Ndoc
		if (@@ERROR <> 0)
		Begin
			RollBack Transaction
			return -5
		End

		Delete From Usuarios Where Ndoc = @Ndoc
		if (@@ERROR <> 0)
		Begin
			RollBack Transaction
			return -3
		End

		Commit Transaction
		return 1

End
go

-----CLIENTES--------------
---ALTA CLIENTES------------
Create Procedure AltaCliente @Ndoc int,@Nom varchar(20),
	@Usuario varchar(20),
	@Constraseña varchar(8),@targeta bigint  As
Begin

if ( Exists(Select * From Usuarios Where Ndoc = @Ndoc))
			Begin
				return -1
			end
	if(exists (select * from Usuarios where Usuario=@Usuario))
	begin
		return -3
	end
	
			
		
		Begin Transaction
	
		Insert usuarios (Ndoc,NomUsuario,Usuario,Constraseña) Values (@Ndoc,@Nom,@Usuario,@Constraseña)
		if (@@ERROR <> 0)
		Begin
			RollBack Transaction
			return -1
		End

		Insert Clientes(Ndoc, Targeta) Values(@Ndoc,@targeta)
		if (@@ERROR<>0)
		Begin
			RollBack Transaction
			return -2
		End

		Commit Transaction
		return 1
		
		
End


go
---------BUSCO CLIENTE
Create Procedure BuscoCliente @Ndoc int As
Begin
	Select * 
	From Usuarios U Inner Join Clientes C on U.Ndoc = C.Ndoc 
	Where C.Ndoc=@Ndoc
End
go

------------------------------------------------------------------
--ADMINISTRADORES

Create Procedure AltaAdministrador @Ndoc int,@Nom varchar(20),
	@Usuario varchar(20),
	@Constraseña varchar(8),@generavuelos bit  As
Begin

if ( Exists(Select * From Usuarios Where Ndoc = @Ndoc))
			Begin
				return -1
			end
	if(exists (select * from Usuarios where Usuario=@Usuario))
	begin
		return -3
	end
		
		Begin Transaction
	
		Insert usuarios (Ndoc,NomUsuario,Usuario,Constraseña) Values (@Ndoc,@Nom,@Usuario,@Constraseña)
		if (@@ERROR <> 0)
		Begin
			RollBack Transaction
			return -1
		End

		Insert Administradores(Ndoc, GenVuelos) Values(@Ndoc,@generavuelos)
		if (@@ERROR<>0)
		Begin
			RollBack Transaction
			return -2
		End

		Commit Transaction
		return 1
End
go
----------------MODIFICO ADMINISTRADOR------------------------------------
Create Procedure ModificoAdministrador @Ndoc int,@Nom varchar(20),
	@Usuario varchar(20),
	@Constraseña varchar(8),@generavuelos bit  As
Begin

if ( NOT Exists(Select * From Administradores Where Ndoc = @Ndoc))
			Begin
				return -1
			end
	if(exists (select * from Usuarios where Usuario=@Usuario))
	begin
		return -3
	end
	
	
		Begin Transaction
	
		UPDATE usuarios SET NomUsuario=@Nom, Usuario=@Usuario ,Constraseña=@Constraseña 
		WHERE Ndoc=@Ndoc
	
		if (@@ERROR <> 0)
		Begin
			RollBack Transaction
			return -1
		End

		update Administradores set GenVuelos=@generavuelos where Ndoc=@Ndoc
		if (@@ERROR<>0)
		Begin
			RollBack Transaction
			return -2
		End

		Commit Transaction
		return 1
End
go

-------------BUSCO ADMINISTRADORES
Create Procedure BuscoAdmin @Ndoc int As
Begin
	Select * 
	From Usuarios U Inner Join Administradores a on U.Ndoc = a.Ndoc 
	Where a.Ndoc=@Ndoc
End
go
-------------------LISTO ADMINSTRADORES
Create Procedure ListoAdmin  As
Begin
	Select * 
	From Usuarios U Inner Join Administradores a on U.Ndoc = a.Ndoc 
	
End
go
------------------------------------------------------------------------------------------------------------------------------------------------
--LOGUEO ADMINISTRADOR
CREATE PROC LogueoAdministrador
@usuario varchar(20),
@contraseña varchar(8)
AS
begin
	SELECT * FROM Usuarios as us inner join  Administradores as ad  ON us.Ndoc = ad.Ndoc
		WHERE us.Usuario = @usuario AND us.Constraseña = @contraseña
end
go
--LOGEO CLIENTE---------------------------------------------------
CREATE PROC LogueoCliente
@usuario varchar(20),
@contraseña varchar(8)
AS
begin
	SELECT * FROM Usuarios as us inner join  Clientes as C  ON us.Ndoc = C.Ndoc
		WHERE us.Usuario = @usuario AND us.Constraseña = @contraseña
end
go



---------------
----RESERVAR ASIENTO-----------------------
Create Procedure ReservaAsiento @codvuelo varchar(18), @Ndoc int, @Nasiento int As
Begin

if (not exists(select * from Vuelos where CodVuelo = @codvuelo))
		begin
		return -1
		end
if not exists(select * from Clientes where Ndoc = @Ndoc)
		begin
		return -2
		end
	
		if exists(select * from Vuelos where (Asientos<@Nasiento or 0>@Nasiento)  and CodVuelo=@codvuelo)
		begin
			return -4
		end
		
		
	if not exists(select * from Reservas where (NAsiento=@Nasiento or Ndoc=@Ndoc) and CodVuelo=@codvuelo)
	
	begin
	

		Insert  Reservas(CodVuelo,Ndoc,NAsiento)  values (@codvuelo,@Ndoc,@Nasiento) 
	
		if(@@error=0)
			return 1
		else
			return -2
			end	

		else
		begin
			return -3
		end
			
End
go

create Procedure LPerV @v varchar(18) AS--Reservas de un Vuelo
Begin
	Select * 
	From Reservas
	Where CodVuelo=@v
End
go
CREATE Procedure BAperV @Codaero varchar(3) As--Busco Aeropuertos sin Tomar en cuenta la Baja logica
Begin
		
	Select * From Aeropuertos where CodAero=@Codaero 
End
go

	
CREATE PROC ListAeroPartidados--Listar Vuelos segun Ciudad de Partida
@Ciudad varchar(20)
as
begin
select v.* from Vuelos v inner join Aeropuertos a on v.Aeropuertosalida =a.CodAero
where Ciudad=@Ciudad 
	
	end
	go
	
CREATE proc procListarAeropuertoCiudadPartida--Listo Ciudad Partida segun el Aeropuerto Salida del Vuelo
as
begin

select  distinct a.Ciudad from Vuelos v inner join Aeropuertos a on v.Aeropuertosalida =a.CodAero
where Baja=0
	end
	go
	
create proc ReservasporClienteXml--Necesario para XML en WS
	@Cliente int
	as
	begin
	select v.* from Vuelos v inner join Reservas r on v.CodVuelo=r.CodVuelo
	where Ndoc=@Cliente
	end
	go
	
USE master
GO

CREATE LOGIN [IIS APPPOOL\DefaultAppPool] FROM WINDOWS
GO

USE Obligatorio
GO

CREATE USER [IIS APPPOOL\DefaultAppPool] FOR LOGIN [IIS APPPOOL\DefaultAppPool]
GO

GRANT execute to [IIS APPPOOL\DefaultAppPool]
GO
