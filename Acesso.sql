create database acesso;
use acesso;

create table autor(
	codigo int not null primary key auto_increment,
    nome varchar(100) not null,
    genero varchar(150) not null,
    endereco varchar(150) not null
)engine = InnoDB;

create table cliente(
	codigo int not null primary key auto_increment,
    nome varchar (150) not null,
    telefone varchar (17) not null,
    endereco varchar (250) not null,
    dataNascimento date not null,
    login varchar (200) not null,
    senha varchar (45) not null
)engine = InnoDB;

create table funcionario(
	codigo int not null primary key auto_increment,
    nome varchar (150) not null,
    endereco varchar (200) not null,
    telefone varchar (45) not null,
    cargo varchar (45) not null,
    salario decimal(10,00) not null
)engine = InnoDB;

create table livro(
	codigo int not null primary key auto_increment,
    descricao varchar(150) not null,
    editoria varchar(45) not null,
    quantidade int not null,
    precoUnitario decimal(10,00) not null
)engine = InnoDB;

create table categoria(
	codigo int not null primary key auto_increment,
    categoria varchar(150) not null
)engine = InnoDB;

create table compra(
	codigo int not null primary key auto_increment,
    dat date not null,
    valorTotal decimal(10,0) not null,
    formaDePagamento varchar(150) not null,
    clienteCodigo int not null,
    funcionarioCodigo int not null
)engine = InnoDB;

create table reserva(
	codigo int not null primary key auto_increment,
    dat dateTime not null,
    clienteCodigo int not null,
    funcionarioCodigo int not null
)engine = InnoDB;

create table possuir(
	codigo int not null primary key auto_increment,
    livroCodigo int not null,
    categoriaCodigo int not null
)engine = InnoDB;

create table ter1(
	codigo int not null primary key auto_increment,
    compraCodigo int not null,
    livroCodigo int not null
)engine = InnoDB;

create table ter2(
	codigo int not null primary key auto_increment,
    reservaCodigo int not null,
    livroCodigo int not null
)engine = InnoDB;

alter table compra add constraint compraCliente foreign key (clienteCodigo) references cliente(codigo);
alter table compra add constraint compraFuncionario foreign key (funcionarioCodigo) references funcionario(codigo);
alter table reserva add constraint reservaFuncionario foreign key (funcionarioCodigo) references funcionario(codigo);
alter table reserva add constraint reservaCliente foreign key (clienteCodigo) references cliente(codigo);
alter table possuir add constraint possuirLivro foreign key (livroCodigo) references livro(codigo);
alter table possuir add constraint possuirCategoria foreign key (categoriaCodigo) references categoria(codigo);
alter table ter1 add constraint ter1Compra foreign key (compraCodigo) references compra(codigo);
alter table ter1 add constraint terLivro foreign key (livroCodigo) references livro(codigo);
alter table ter2 add constraint ter2Reserva foreign key (reservaCodigo) references reserva(codigo);
alter table ter2 add constraint ter2Livro foreign key (livroCodigo) references livro(codigo);