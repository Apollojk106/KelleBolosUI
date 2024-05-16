Codigo do mysql usado:

create database keebolos;

use keebolos;

create table usuario(
Nome varchar(200),
 Usuario varchar(200),
 Telefone varchar(200),
 Email varchar(200),
 Senha varchar(200),
 SaltKey varchar(200));

create table endereço(
Usuario varchar(200),
 CEP varchar(200),
 Bairro varchar(200),
 Rua varchar(200),
 Numero varchar(200),
 Complemento varchar(200));
