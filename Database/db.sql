--
-- PostgreSQL database dump
--

-- Dumped from database version 14.2
-- Dumped by pg_dump version 14.2

SET statement_timeout = 0;
SET lock_timeout = 0;
SET idle_in_transaction_session_timeout = 0;
SET client_encoding = 'UTF8';
SET standard_conforming_strings = on;
SELECT pg_catalog.set_config('search_path', '', false);
SET check_function_bodies = false;
SET xmloption = content;
SET client_min_messages = warning;
SET row_security = off;

--
-- Name: telegram; Type: SCHEMA; Schema: -; Owner: postgres
--

CREATE SCHEMA telegram;


ALTER SCHEMA telegram OWNER TO postgres;

SET default_tablespace = '';

SET default_table_access_method = heap;

--
-- Name: fchat; Type: TABLE; Schema: telegram; Owner: postgres
--

CREATE TABLE telegram.fchat (
    mark integer,
    content text,
    url text
);


ALTER TABLE telegram.fchat OWNER TO postgres;

--
-- Name: group; Type: TABLE; Schema: telegram; Owner: postgres
--

CREATE TABLE telegram."group" (
    groupnumber integer,
    a integer,
    b integer,
    c integer,
    detect boolean DEFAULT true,
    groupname text,
    mark integer,
    groupphoto text
);


ALTER TABLE telegram."group" OWNER TO postgres;

--
-- Name: information; Type: TABLE; Schema: telegram; Owner: postgres
--

CREATE TABLE telegram.information (
    account integer NOT NULL,
    password text NOT NULL,
    email text NOT NULL,
    phone integer NOT NULL,
    name text,
    introduce text,
    realstate boolean DEFAULT false NOT NULL,
    pipename integer,
    photo text,
    groupname integer,
    username text
);


ALTER TABLE telegram.information OWNER TO postgres;

--
-- Name: usera; Type: TABLE; Schema: telegram; Owner: postgres
--

CREATE TABLE telegram.usera (
    friendaccount integer NOT NULL,
    remark text DEFAULT NULL::bpchar,
    blacklist boolean DEFAULT false,
    block integer DEFAULT 1,
    state boolean DEFAULT false,
    realname text,
    url text
);


ALTER TABLE telegram.usera OWNER TO postgres;

--
-- Name: userb; Type: TABLE; Schema: telegram; Owner: postgres
--

CREATE TABLE telegram.userb (
    friendaccount integer,
    remark text DEFAULT NULL::bpchar,
    blacklist boolean DEFAULT false,
    block integer DEFAULT 1,
    state boolean DEFAULT false,
    realname text,
    url text
);


ALTER TABLE telegram.userb OWNER TO postgres;

--
-- Name: userc; Type: TABLE; Schema: telegram; Owner: postgres
--

CREATE TABLE telegram.userc (
    friendaccount integer,
    remark text DEFAULT NULL::bpchar,
    blacklist boolean DEFAULT false,
    block integer DEFAULT 1,
    state boolean DEFAULT false,
    realname text,
    url text
);


ALTER TABLE telegram.userc OWNER TO postgres;

--
-- Data for Name: fchat; Type: TABLE DATA; Schema: telegram; Owner: postgres
--

COPY telegram.fchat (mark, content, url) FROM stdin;
1		\N
\.


--
-- Data for Name: group; Type: TABLE DATA; Schema: telegram; Owner: postgres
--

COPY telegram."group" (groupnumber, a, b, c, detect, groupname, mark, groupphoto) FROM stdin;
5555	1234	\N	\N	t	www	\N	F:\\SuperTelegram\\Photo\\group.jpg
1234	5678	1234	123	t	yijiar	\N	F:\\SuperTelegram\\Photo\\group.jpg
\.


--
-- Data for Name: information; Type: TABLE DATA; Schema: telegram; Owner: postgres
--

COPY telegram.information (account, password, email, phone, name, introduce, realstate, pipename, photo, groupname, username) FROM stdin;
3456	ceaa28bba4caba687dc31b1bbe79eca3c70c33f871f1ce8f528cf9ab5cfd76dd	3456	3456	3456	wwww	t	0	F:\\SuperTelegram\\Photo\\search.png	\N	userb
1234	03ac674216f3e15c761ee1a5e255f067953623c8b388b4459e13f978d7c846f4	addd	111133	狗蛋ddd	你好你好    ddd	f	2	F:\\SuperTelegram\\Photo\\2020022708453463508.jpg	\N	usera
9999	sa	as	11	9999	hfusdifohasuhfauiwoefaio hefuiawiufoehuifgwe igf yeogwagyoaiewfyi gayuifawyeo gfyi gefyw	f	4	F:\\SuperTelegram\\Photo\\2020022708453463508.jpg	\N	\N
789	35a9e381b1a27567549b5f8a6f783c167ebf809f1c4d6a9e367240484d8ce281	789	789	789	请写一个介绍	f	6	F:\\SuperTelegram\\Photo\\white.jpg	\N	userc
\.


--
-- Data for Name: usera; Type: TABLE DATA; Schema: telegram; Owner: postgres
--

COPY telegram.usera (friendaccount, remark, blacklist, block, state, realname, url) FROM stdin;
3456	啊啊啊	t	1	f	3456	F:\\SuperTelegram\\Photo\\search.png
9999	1234	f	1	f	9999	F:\\SuperTelegram\\Photo\\2020022708453463508.jpg
\.


--
-- Data for Name: userb; Type: TABLE DATA; Schema: telegram; Owner: postgres
--

COPY telegram.userb (friendaccount, remark, blacklist, block, state, realname, url) FROM stdin;
1234	\N	t	1	f	狗蛋ddd	F:\\SuperTelegram\\Photo\\2020022708453463508.jpg
\.


--
-- Data for Name: userc; Type: TABLE DATA; Schema: telegram; Owner: postgres
--

COPY telegram.userc (friendaccount, remark, blacklist, block, state, realname, url) FROM stdin;
\.


--
-- Name: information information_pk; Type: CONSTRAINT; Schema: telegram; Owner: postgres
--

ALTER TABLE ONLY telegram.information
    ADD CONSTRAINT information_pk PRIMARY KEY (account);


--
-- Name: usera usera_pk; Type: CONSTRAINT; Schema: telegram; Owner: postgres
--

ALTER TABLE ONLY telegram.usera
    ADD CONSTRAINT usera_pk PRIMARY KEY (friendaccount);


--
-- Name: information_account_uindex; Type: INDEX; Schema: telegram; Owner: postgres
--

CREATE UNIQUE INDEX information_account_uindex ON telegram.information USING btree (account);


--
-- Name: usera_friendaccount_uindex; Type: INDEX; Schema: telegram; Owner: postgres
--

CREATE UNIQUE INDEX usera_friendaccount_uindex ON telegram.usera USING btree (friendaccount);


--
-- Name: userb_friendaccount_uindex; Type: INDEX; Schema: telegram; Owner: postgres
--

CREATE UNIQUE INDEX userb_friendaccount_uindex ON telegram.userb USING btree (friendaccount);


--
-- Name: userc_friendaccount_uindex; Type: INDEX; Schema: telegram; Owner: postgres
--

CREATE UNIQUE INDEX userc_friendaccount_uindex ON telegram.userc USING btree (friendaccount);


--
-- PostgreSQL database dump complete
--

