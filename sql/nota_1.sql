use net_reservahoramedico;

--*** SP Estado ***--
go
drop procedure sp_listar_estado;
go
create procedure sp_listar_estado
as
	select * from estado;
go

go
drop procedure sp_buscar_estado;
go
create procedure sp_buscar_estado
@idestado int
as
	select * from estado
	where idestado = @idestado;
go

go
drop procedure sp_update_estado;
go
create procedure sp_update_estado
@idestado int,
@descripcion varchar(50)
as
	update estado set 
	descripcion = @descripcion 
	where idestado = @idestado;
go

go
drop procedure sp_delete_estado;
go
create procedure sp_delete_estado
@idestado int
as
	delete from estado
	where idestado = @idestado;
go

go
drop procedure sp_insert_estado;
go
create procedure sp_insert_estado
@descripcion varchar(50)
as

	insert Into estado(descripcion) 
	VALUES(@descripcion);
go

--*** SP Especialidad ***--

go
drop procedure sp_listar_especialidad;
go
create procedure sp_listar_especialidad
as
	select * from especialidad;
go

go
drop procedure sp_buscar_especialidad;
go
create procedure sp_buscar_especialidad
@idespecialidad int
as
	select * from especialidad
	where idespecialidad = @idespecialidad;
go

go
drop procedure sp_update_especialidad;
go
create procedure sp_update_especialidad
@idespecialidad int,
@descripcion varchar(50)
as
	update especialidad set 
	descripcion = @descripcion 
	where idespecialidad = @idespecialidad;
go

go
drop procedure sp_delete_especialidad;
go
create procedure sp_delete_especialidad
@idespecialidad int
as
	delete from especialidad
	where idespecialidad = @idespecialidad;
go

go
drop procedure sp_insert_especialidad;
go
create procedure sp_insert_especialidad
@descripcion varchar(50)
as

	insert Into especialidad(descripcion) 
	VALUES(@descripcion);
go

--*** SP Reserva ***--

go
drop procedure sp_listar_reserva;
go
create procedure sp_listar_reserva
as
	select idreserva, medico.idmedico ,medico.nombres as medico_nombre, medico.apellidos as medico_apellido, medico.email as medico_email, medico.telefono as medico_telefono, --medico
	especialidad.idespecialidad, especialidad.idespecialidad as especialidad,
	paciente.idpaciente, paciente.nombres as paciente_nombres, paciente.apellidos as paciente_apellidos, paciente.email as paciente_email, paciente.telefono as paciente_telefono, genero, edad,
	hora.idhora,fecha, horaminuto, hora.idestado, estado.descripcion as estado
	from  reserva
	inner join medico
	on reserva.idmedico = medico.idmedico
	inner join especialidad
	on medico.idespecialidad = especialidad.idespecialidad
	inner join paciente 
	on reserva.idpaciente = paciente.idpaciente
	inner join hora
	on reserva.idhora = hora.idhora
	inner join estado
	on hora.idestado = estado.idestado
go


