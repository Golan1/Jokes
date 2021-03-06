drop table relation;
drop table word_in_group;
drop table jk_group;
drop table word_in_joke;
drop sequence joke_seq;
drop table joke;
drop sequence jk_file_seq;
drop table jk_file;

create table jk_file(
id number primary key,
title varchar2(100) not null,
author varchar2(100),
rating number,
source varchar2(500),
creation_date date not null,
insertion_date date not null);

CREATE SEQUENCE jk_file_seq
 START WITH     1
 INCREMENT BY   1
 NOCACHE
 NOCYCLE;

create table joke(
id number primary key,
file_id number not null,
joke_index number not null,
foreign key (file_id) references jk_file(id));

CREATE SEQUENCE joke_seq
 START WITH     1
 INCREMENT BY   1
 NOCACHE
 NOCYCLE;
 
create table word_in_joke(
joke_id number,
index_in_joke number,
text varchar2(50) not null,
text_for_search varchar2(50),
line_index number,
index_in_line number,
primary key (joke_id, index_in_joke),
foreign key (joke_id) references joke(id));


create table jk_group(
id number primary key,
name varchar2(100) unique not null);

CREATE SEQUENCE jk_group_seq
 START WITH     1
 INCREMENT BY   1
 NOCACHE
 NOCYCLE;



create table word_in_group(
group_id number,
text varchar2(50),
primary key (group_id, text),
foreign  key (group_id) references jk_group(id));


create table jk_relation(
id number primary key,
name varchar2(100) unique not null);

CREATE SEQUENCE jk_relation_seq
 START WITH     1
 INCREMENT BY   1
 NOCACHE
 NOCYCLE;

create table tupple_in_relation(
relation_id number,
word1 varchar2(50) not null,
word2 varchar2(50) not null,
primary Key (relation_id, word1,word1),
foreign key (relation_id) references jk_relation(id));


