CREATE TABLE IF NOT EXISTS public.documents
(
	id integer NOT NULL,
	doctype integer NOT NULL,
	purpose integer NOT NULL,
	googledrivefileid character varying COLLATE pg_catalog."default" NOT NULL,
	CONSTRAINT pk_documents PRIMARY KEY (id),
	CONSTRAINT documents_unq_googledrivefileid UNIQUE (googledrivefileid)
);
CREATE TABLE IF NOT EXISTS public.videos
(
    id integer NOT NULL,
    youtubeid character varying COLLATE pg_catalog."default" NOT NULL,
    likes integer,
    dislikes integer,
    shortname character varying COLLATE pg_catalog."default" NOT NULL,
    identifier character varying COLLATE pg_catalog."default" NOT NULL,
    owner character varying COLLATE pg_catalog."default" NOT NULL,
	isprivate boolean NOT NULL,
	additionaltextdocumentid integer NULL,
	musxdocumentid integer NULL,
    CONSTRAINT pk_videos PRIMARY KEY (id),
    CONSTRAINT videos_unq_youtube_id UNIQUE (youtubeid),
	CONSTRAINT fk_videos_additionaltextdocumentid FOREIGN KEY (additionaltextdocumentid)
    REFERENCES public.documents (id) MATCH SIMPLE
    ON UPDATE NO ACTION
    ON DELETE CASCADE,
	CONSTRAINT fk_videos_musxdocumentid FOREIGN KEY (musxdocumentid)
    REFERENCES public.documents (id) MATCH SIMPLE
    ON UPDATE NO ACTION
    ON DELETE CASCADE
);
CREATE TABLE IF NOT EXISTS public.performers
(
    id integer NOT NULL,
    ord integer NOT NULL,
    name character varying COLLATE pg_catalog."default" NOT NULL,
    CONSTRAINT pk_performers PRIMARY KEY (id)
);
CREATE TABLE IF NOT EXISTS public.dates
(
    id integer NOT NULL,
	videos_last_refreshed timestamp without time zone,
    CONSTRAINT pk_dates PRIMARY KEY (id)
);
CREATE TABLE IF NOT EXISTS public.rulez_official
(
    id integer NOT NULL,
    ord integer NOT NULL,
    "number" character varying COLLATE pg_catalog."default" NOT NULL,
    rule character varying COLLATE pg_catalog."default" NOT NULL,
    source character varying COLLATE pg_catalog."default" NOT NULL,
    actualrule character varying COLLATE pg_catalog."default" NOT NULL,
	videoid1 integer NULL,
	videoid2 integer NULL,
	video1isadditionaltext boolean NOT NULL,
    CONSTRAINT pk_rulez_official PRIMARY KEY (id),
	CONSTRAINT fk_rulez_official_video1 FOREIGN KEY (videoid1)
    REFERENCES public.videos (id) MATCH SIMPLE
    ON UPDATE NO ACTION
    ON DELETE CASCADE,
	CONSTRAINT fk_rulez_official_video2 FOREIGN KEY (videoid2)
    REFERENCES public.videos (id) MATCH SIMPLE
    ON UPDATE NO ACTION
    ON DELETE CASCADE
);
CREATE TABLE IF NOT EXISTS public.rulez_unofficial
(
    id integer NOT NULL,
    ord integer NOT NULL,
    rule character varying COLLATE pg_catalog."default" NOT NULL,
    source character varying COLLATE pg_catalog."default" NOT NULL,
	videoid1 integer NULL,
	videoid2 integer NULL,
	video1isadditionaltext boolean NOT NULL,
    CONSTRAINT pk_rulez_unofficial PRIMARY KEY (id),
	CONSTRAINT fk_rulez_unofficial_video1 FOREIGN KEY (videoid1)
    REFERENCES public.videos (id) MATCH SIMPLE
    ON UPDATE NO ACTION
    ON DELETE CASCADE,
	CONSTRAINT fk_rulez_unofficial_video2 FOREIGN KEY (videoid2)
    REFERENCES public.videos (id) MATCH SIMPLE
    ON UPDATE NO ACTION
    ON DELETE CASCADE
);
CREATE TABLE IF NOT EXISTS public.exception_list_member_types
(
    id integer NOT NULL,
	ord integer NOT NULL,
	name character varying COLLATE pg_catalog."default" NOT NULL,
	CONSTRAINT pk_exception_list_types PRIMARY KEY (id)
);
CREATE TABLE IF NOT EXISTS public.exception_lists
(
    id integer NOT NULL,
	ord integer NOT NULL,
	name character varying COLLATE pg_catalog."default" NOT NULL,
	detail character varying COLLATE pg_catalog."default" NOT NULL,
	videoid integer NOT NULL,
	CONSTRAINT pk_exception_lists PRIMARY KEY (id),
	CONSTRAINT fk_exception_lists_video FOREIGN KEY (videoid)
    REFERENCES public.videos (id) MATCH SIMPLE
    ON UPDATE NO ACTION
    ON DELETE CASCADE
);
CREATE TABLE IF NOT EXISTS public.exception_list_members
(
	exceptionlistid integer NOT NULL,
    ord integer NOT NULL,
	name character varying COLLATE pg_catalog."default" NOT NULL,
	categoryid integer NOT NULL,
	videoid integer NOT NULL,
	CONSTRAINT pk_exception_list_members PRIMARY KEY (exceptionlistid,ord),
	CONSTRAINT fk_exception_list_members_exception_list FOREIGN KEY (exceptionlistid)
    REFERENCES public.exception_lists (id) MATCH SIMPLE
    ON UPDATE NO ACTION
    ON DELETE CASCADE,
	CONSTRAINT fk_exception_list_members_video FOREIGN KEY (videoid)
    REFERENCES public.videos (id) MATCH SIMPLE
    ON UPDATE NO ACTION
    ON DELETE CASCADE,
	CONSTRAINT fk_exception_list_members_category FOREIGN KEY (categoryid)
    REFERENCES public.exception_list_member_types (id) MATCH SIMPLE
    ON UPDATE NO ACTION
    ON DELETE CASCADE
);
CREATE TABLE IF NOT EXISTS public.lyrics_analyses
(
    id integer NOT NULL,
    ord integer NOT NULL,
	videoid integer NOT NULL,
	location integer NOT NULL,
	isparody boolean NOT NULL,
    CONSTRAINT pk_lyrics_analyses PRIMARY KEY (id),
	CONSTRAINT fk_lyrics_analyses_video FOREIGN KEY (videoid)
    REFERENCES public.videos (id) MATCH SIMPLE
    ON UPDATE NO ACTION
    ON DELETE CASCADE
);
CREATE TABLE IF NOT EXISTS public.copyrights_found
(
    id integer NOT NULL,
    ord integer NOT NULL,
    song character varying COLLATE pg_catalog."default" NOT NULL,
	copyright character varying COLLATE pg_catalog."default" NOT NULL,
	videoid1 integer NOT NULL,
	videoid2 integer NULL,
    CONSTRAINT pk_copyrights_found PRIMARY KEY (id),
	CONSTRAINT fk_copyrights_found_video1 FOREIGN KEY (videoid1)
    REFERENCES public.videos (id) MATCH SIMPLE
    ON UPDATE NO ACTION
    ON DELETE CASCADE,
	CONSTRAINT fk_copyrights_found_video2 FOREIGN KEY (videoid2)
    REFERENCES public.videos (id) MATCH SIMPLE
    ON UPDATE NO ACTION
    ON DELETE CASCADE
);
CREATE TABLE IF NOT EXISTS public.copyrights_missing
(
    id integer NOT NULL,
    ord integer NOT NULL,
    song character varying COLLATE pg_catalog."default" NOT NULL,
	copyright character varying COLLATE pg_catalog."default" NOT NULL,
	videoid1 integer NOT NULL,
	videoid2 integer NULL,
    CONSTRAINT pk_copyrights_missing PRIMARY KEY (id),
	CONSTRAINT fk_copyrights_missing_video1 FOREIGN KEY (videoid1)
    REFERENCES public.videos (id) MATCH SIMPLE
    ON UPDATE NO ACTION
    ON DELETE CASCADE,
	CONSTRAINT fk_copyrights_missing_video2 FOREIGN KEY (videoid2)
    REFERENCES public.videos (id) MATCH SIMPLE
    ON UPDATE NO ACTION
    ON DELETE CASCADE
);
CREATE TABLE IF NOT EXISTS public.complaints
(
    id integer NOT NULL,
    ord integer NOT NULL,
    target character varying COLLATE pg_catalog."default" NOT NULL,
    detail character varying COLLATE pg_catalog."default" NOT NULL,
    source character varying COLLATE pg_catalog."default" NOT NULL,
    comment character varying COLLATE pg_catalog."default" NOT NULL,
	videoid integer NULL,
    "number" character varying COLLATE pg_catalog."default" NOT NULL,
    CONSTRAINT pk_complaints PRIMARY KEY (id),
	CONSTRAINT fk_complaints_video FOREIGN KEY (videoid)
    REFERENCES public.videos (id) MATCH SIMPLE
    ON UPDATE NO ACTION
    ON DELETE CASCADE
);
CREATE TABLE IF NOT EXISTS public.landing_pages
(
 id integer NOT NULL,
 ord integer NOT NULL,
 name character varying COLLATE pg_catalog."default" NOT NULL,
 url character varying COLLATE pg_catalog."default" NOT NULL,
 CONSTRAINT pk_landing_pages PRIMARY KEY (id),
 CONSTRAINT landing_pages_unq_name UNIQUE (name)
);
CREATE TABLE IF NOT EXISTS public.videolist_mainline
(
    videoid integer NOT NULL,
    ord integer NOT NULL,
    episode character varying COLLATE pg_catalog."default" NOT NULL,
    theme character varying COLLATE pg_catalog."default" NOT NULL,
    audience character varying COLLATE pg_catalog."default" NOT NULL,
    majorrulez character varying COLLATE pg_catalog."default" NOT NULL,
    memes character varying COLLATE pg_catalog."default" NOT NULL,
    minorrulez character varying COLLATE pg_catalog."default" NOT NULL,
    CONSTRAINT pk_videolist_mainline PRIMARY KEY (videoid),
    CONSTRAINT fk_videolist_mainline_videos FOREIGN KEY (videoid)
        REFERENCES public.videos (id) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE CASCADE
);
CREATE TABLE IF NOT EXISTS public.videolist_sillysongs
(
    videoid integer NOT NULL,
    rulez character varying COLLATE pg_catalog."default" NOT NULL,
    "number" character varying COLLATE pg_catalog."default" NOT NULL,
    memes character varying COLLATE pg_catalog."default" NOT NULL,
    ord integer NOT NULL,
    CONSTRAINT pk_videolist_sillysongs PRIMARY KEY (videoid),
    CONSTRAINT fk_videolist_sillysongs_videos FOREIGN KEY (videoid)
        REFERENCES public.videos (id) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE CASCADE
);
CREATE TABLE IF NOT EXISTS public.videolist_workvideos
(
    videoid integer NOT NULL,
    ord integer NOT NULL,	
    concepts character varying COLLATE pg_catalog."default" NOT NULL,
    CONSTRAINT pk_videolist_workvideos PRIMARY KEY (videoid),
    CONSTRAINT fk_videolist_workvideos_videos FOREIGN KEY (videoid)
        REFERENCES public.videos (id) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE CASCADE
);
CREATE TABLE IF NOT EXISTS public.videolist_kidzvideos
(
    videoid integer NOT NULL,
    ord integer NOT NULL,	
    CONSTRAINT pk_videolist_kidzvideos PRIMARY KEY (videoid),
    CONSTRAINT fk_videolist_kidzvideos_videos FOREIGN KEY (videoid)
        REFERENCES public.videos (id) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE CASCADE
);
CREATE TABLE IF NOT EXISTS public.videolist_unexplainablevideos
(
    videoid integer NOT NULL,
    ord integer NOT NULL,
    reason character varying COLLATE pg_catalog."default" NOT NULL,
	musxdocumentid integer NULL,
    CONSTRAINT pk_videolist_unexplainablevideos PRIMARY KEY (videoid),
    CONSTRAINT fk_videolist_unexplainablevideos_videos FOREIGN KEY (videoid)
        REFERENCES public.videos (id) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE CASCADE,
	CONSTRAINT fk_videolist_unexplainablevideos_musxdocumentid FOREIGN KEY (musxdocumentid)
    REFERENCES public.documents (id) MATCH SIMPLE
    ON UPDATE NO ACTION
    ON DELETE CASCADE
);
CREATE TABLE IF NOT EXISTS public.videolist_musicvideos
(
    videoid integer NOT NULL,
    ord integer NOT NULL,
	performerid integer NOT NULL,
    piece character varying COLLATE pg_catalog."default" NOT NULL,
    author character varying COLLATE pg_catalog."default" NOT NULL,
    setting character varying COLLATE pg_catalog."default" NOT NULL,
    CONSTRAINT pk_videolist_musicvideos PRIMARY KEY (videoid),
    CONSTRAINT fk_videolist_musicvideos_performers FOREIGN KEY (performerid)
        REFERENCES public.performers (id) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE CASCADE,
    CONSTRAINT fk_videolist_musicvideos_videos FOREIGN KEY (videoid)
        REFERENCES public.videos (id) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE CASCADE
)

TABLESPACE pg_default;

ALTER TABLE IF EXISTS public.videos OWNER to postgres;
ALTER TABLE IF EXISTS public.performers OWNER to postgres;
ALTER TABLE IF EXISTS public.dates OWNER to postgres;
ALTER TABLE IF EXISTS public.complaints OWNER to postgres;
ALTER TABLE IF EXISTS public.landing_pages OWNER to postgres;
ALTER TABLE IF EXISTS public.copyrights_found OWNER to postgres;
ALTER TABLE IF EXISTS public.copyrights_missing OWNER to postgres;
ALTER TABLE IF EXISTS public.lyrics_analyses OWNER to postgres;
ALTER TABLE IF EXISTS public.videolist_mainline OWNER to postgres;
ALTER TABLE IF EXISTS public.videolist_sillysongs OWNER to postgres;
ALTER TABLE IF EXISTS public.videolist_workvideos OWNER to postgres;
ALTER TABLE IF EXISTS public.videolist_kidzvideos OWNER to postgres;
ALTER TABLE IF EXISTS public.videolist_unexplainablevideos OWNER to postgres;
ALTER TABLE IF EXISTS public.videolist_musicvideos OWNER to postgres;
ALTER TABLE IF EXISTS public.rulez_official OWNER to postgres;
ALTER TABLE IF EXISTS public.rulez_unofficial OWNER to postgres;
ALTER TABLE IF EXISTS public.exception_list_member_types OWNER to postgres;
ALTER TABLE IF EXISTS public.exception_lists OWNER to postgres;
ALTER TABLE IF EXISTS public.exception_list_members OWNER to postgres;

CREATE INDEX IF NOT EXISTS fki_fk_videos_additionaltextdocumentid
    ON public.videos USING btree
    (additionaltextdocumentid ASC NULLS LAST)
    TABLESPACE pg_default;
CREATE INDEX IF NOT EXISTS fki_fk_videos_musxdocumentid
    ON public.videos USING btree
    (musxdocumentid ASC NULLS LAST)
    TABLESPACE pg_default;
CREATE INDEX IF NOT EXISTS fki_fk_videolist_mainline_videos
    ON public.videolist_mainline USING btree
    (videoid ASC NULLS LAST)
    TABLESPACE pg_default;
CREATE INDEX IF NOT EXISTS fki_fk_videolist_sillysongs_videos
    ON public.videolist_sillysongs USING btree
    (videoid ASC NULLS LAST)
    TABLESPACE pg_default;
CREATE INDEX IF NOT EXISTS fki_fk_videolist_workvideos_videos
    ON public.videolist_workvideos USING btree
    (videoid ASC NULLS LAST)
    TABLESPACE pg_default;
CREATE INDEX IF NOT EXISTS fki_fk_videolist_kidzvideos_videos
    ON public.videolist_kidzvideos USING btree
    (videoid ASC NULLS LAST)
    TABLESPACE pg_default;
CREATE INDEX IF NOT EXISTS fki_fk_videolist_musicvideos_videos
    ON public.videolist_musicvideos USING btree
    (videoid ASC NULLS LAST)
    TABLESPACE pg_default;
CREATE INDEX IF NOT EXISTS fki_fk_videolist_musicvideos_performers
    ON public.videolist_musicvideos USING btree
    (performerid ASC NULLS LAST)
    TABLESPACE pg_default;
CREATE INDEX IF NOT EXISTS fki_fk_exception_lists_video
    ON public.exception_lists USING btree
    (videoid ASC NULLS LAST)
    TABLESPACE pg_default;
CREATE INDEX IF NOT EXISTS fki_fk_exception_list_members_exception_list
    ON public.exception_list_members USING btree
    (exceptionlistid ASC NULLS LAST)
    TABLESPACE pg_default;
CREATE INDEX IF NOT EXISTS fki_fk_exception_list_members_video
    ON public.exception_list_members USING btree
    (videoid ASC NULLS LAST)
    TABLESPACE pg_default;
CREATE INDEX IF NOT EXISTS fki_fk_exception_list_members_category
    ON public.exception_list_members USING btree
    (categoryid ASC NULLS LAST)
    TABLESPACE pg_default;
CREATE INDEX IF NOT EXISTS fki_fk_videolist_unexplainablevideos_videos
    ON public.videolist_unexplainablevideos USING btree
    (videoid ASC NULLS LAST)
    TABLESPACE pg_default;
CREATE INDEX IF NOT EXISTS fki_fk_videolist_unexplainablevideos_musxdocumentid
    ON public.videolist_unexplainablevideos USING btree
    (musxdocumentid ASC NULLS LAST)
    TABLESPACE pg_default;
CREATE INDEX IF NOT EXISTS fki_fk_lyrics_analyses_video
    ON public.lyrics_analyses USING btree
    (videoid ASC NULLS LAST)
    TABLESPACE pg_default;
CREATE INDEX IF NOT EXISTS fki_fk_complaints_video
    ON public.complaints USING btree
    (videoid ASC NULLS LAST)
    TABLESPACE pg_default;
CREATE INDEX IF NOT EXISTS fki_fk_copyrights_found_video1
    ON public.copyrights_found USING btree
    (videoid1 ASC NULLS LAST)
    TABLESPACE pg_default;
CREATE INDEX IF NOT EXISTS fki_fk_copyrights_found_video2
    ON public.copyrights_found USING btree
    (videoid2 ASC NULLS LAST)
    TABLESPACE pg_default;
CREATE INDEX IF NOT EXISTS fki_fk_copyrights_missing_video1
    ON public.copyrights_missing USING btree
    (videoid1 ASC NULLS LAST)
    TABLESPACE pg_default;
CREATE INDEX IF NOT EXISTS fki_fk_copyrights_missing_video2
    ON public.copyrights_missing USING btree
    (videoid2 ASC NULLS LAST)
    TABLESPACE pg_default;
CREATE INDEX IF NOT EXISTS fki_fk_rulez_official_video1
    ON public.rulez_official USING btree
    (videoid1 ASC NULLS LAST)
    TABLESPACE pg_default;
CREATE INDEX IF NOT EXISTS fki_fk_rulez_official_video2
    ON public.rulez_official USING btree
    (videoid2 ASC NULLS LAST)
    TABLESPACE pg_default;
CREATE INDEX IF NOT EXISTS fki_fk_rulez_unofficial_video1
    ON public.rulez_unofficial USING btree
    (videoid1 ASC NULLS LAST)
    TABLESPACE pg_default;
CREATE INDEX IF NOT EXISTS fki_fk_rulez_unofficial_video2
    ON public.rulez_unofficial USING btree
    (videoid2 ASC NULLS LAST)
    TABLESPACE pg_default;