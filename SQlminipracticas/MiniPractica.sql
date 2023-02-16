/*
1. Traer todos los discos con su respectivo estilo. La consulta debe mostrar: Nombre de disco, Fecha de lanzamiento, Estilo (no el id, sino la descripción).
*/

-- Select Titulo,FechaLanzamiento,Descripcion From DISCOS D,ESTILOS E Where D.IdEstilo = E.Id

/*
2. Insertar al menos dos estilos nuevos y un tipo de edición de disco. 
*/
--Ingreso dos nuevo estilo

--Insert Into ESTILOS (Descripcion)
--values ('Clasica')

--Insert Into ESTILOS (Descripcion)
--values ('Jazz')


--Ingreso de un tipo de edición de disco.

--Insert Into TIPOSEDICION (Descripcion) Values ('CD digital')


/*
3. Insertar al menos dos discos nuevos cargando correctamente su información.
*/

--Insert Into DISCOS(Titulo,FechaLanzamiento,CantidadCanciones,UrlImagenTapa,IdEstilo,IdTipoEdicion)
--values ('Nectar',GETDATE(),18,'music.apple.com/es/album/nectar/1506574436',4,4)

--Insert Into DISCOS(Titulo,FechaLanzamiento,CantidadCanciones,UrlImagenTapa,IdEstilo,IdTipoEdicion)
--values ('Ballads 1',GETDATE(),12,'music.apple.com/es/album/Ballads1/1506574436',1,1)

/*
4. Actualizar al menos un disco modificando la cantidad de canciones y la fecha de lanzamiento. No te olvides del Where.
*/

--Update DISCOS Set Titulo = 'joji' Where Id = 2
--Update DISCOS Set FechaLanzamiento = '2004-01-02 00:10:00' Where Id = 2

/*
5. Borrar un disco a elección.
*/

--Delete From DISCOS Where id = 2

/*
6. Traer todos los estilos que estén asociados a algún disco.
*/

--Select Descripcion From ESTILOS e,DISCOS d Where d.IdEstilo = e.Id  

/*
7. Traer todos los discos con el siguiente formato: Nombre, Estilo, Edición (todo texto).
*/

--Select DI.Titulo,ES.Descripcion,TE.Descripcion From DISCOS DI,ESTILOS ES,TIPOSEDICION TE Where DI.IdEstilo = ES.Id AND DI.IdTipoEdicion = Te.Id

/*
8. Traer todos los discos que contengan en su nombre la sílaba "ho".
*/

--Select * From DISCOS Where Titulo Like '%ho%'; 



--Select * From DISCOS
--Select * From ESTILOS
--Select * From TIPOSEDICION