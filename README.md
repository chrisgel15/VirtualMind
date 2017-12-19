# VirtualMind

1) Abrir con Visual Studio (está hecho con version 2017)
2) Chequear si está configurada la opcion para correr multiples proyectos a la vez: 
  Go to Solution properties -> Common properties -> Startup Project and select Multiple startup projects.
3) Correr la aplicacion, se deben iniciar los Servicios en un explorador y el cliente en el otro.
4) En mi entorno, los servicios corren en el puerto: 55886, verificar si al ejecutar se levantan en ese puerto. 
5) En caso de iniciarse en otro puerto, se debe ir al webConfig de la aplicacion Cliente y modificar la clave llamada "servicesUrl",
que apunta al servidor y puerto de los servicios.
6) La aplicacion funciona con la base de datos de SQL local, y está configurada para crear la base de datos y popularla
al iniciarse, por lo que no debe correrse ningun script.
