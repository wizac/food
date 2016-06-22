
create table catComida
(
idcatcomida int identity(1,1) primary key,
nombre nvarchar(30),
descripcion nvarchar(4000)

)
create table usuario
(
idusuario int identity(1,1) primary key,
ncombre nvarchar(20) not null,
perfil nvarchar(4000) null,
foto image null,
usser nvarchar(40) not null,
pass nvarchar(40) not null,
fechainicio datetime not null,
nivelseg nvarchar(20) not null,
activo bit default  1
)
create table receta
(
idreceta int identity(1,1) primary key,
nombre nvarchar(20) not null,
Descripcion nvarchar(20) not null,
rating float default 0,
pendiente bit default 0,
tiempo nvarchar(40) not null,
foto image null,
porciones int not null,
activo bit default 1,
idusuario int references usuario(idusuario),
idcatcom int references catcomida(idcatcomida)
)




create table ingrediente
(
idingrediente int identity(1,1) primary key,
nombre nvarchar(30) not null,
imagen image null,
Descripcion nvarchar(4000)
)

create table umedida
(
idumedida int identity(1,1) primary key,
descripcion nvarchar(20)
)

create table contiene
(
idreceta int references receta(idreceta),
idingrediente int references ingrediente(idingrediente),
idumedida int references umedida(idumedida),
cantidad float
)

create table usuarioVoto
(
idusuario int references usuario(idusuario),
idreceta int references receta(idreceta),
voto int default 0
)


create table sigue
(
sigue int references usuario(idusuario),
seguidor int references usuario(idusuario)
)

create table favoritos
(
usuario int references usuario(idusuario),
receta int references receta(idreceta)
)
create table grupo
(
idgrupo int identity(1,1) primary key,
nombre nvarchar(50) not null,
descripcion nvarchar(50) null,
creator int references usuario(idusuario) not null,
tema nvarchar(4000) null,
activo bit default 1
)
create table denuncias
(
iddenuncia int identity(1,1) primary key,
idusuario int references usuario(idusuario),
mensaje nvarchar(4000) null,
denunciarec int references receta(idreceta) null,
denunciausu int references usuario(idusuario) null,
denunciagrup int references grupo(idgrupo) null,
fecha datetime,
resuelto bit default 1
)

create table integra
(
idusuario int references usuario(idusuario),
idgrupo int references grupo(idgrupo),
activo bit default 1
)


