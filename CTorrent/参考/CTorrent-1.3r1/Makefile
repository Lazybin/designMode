CFLAGS=-Wall -O2
LIBS=-lmd

all: ctorrent

ctorrent: ctorrent.o tracker.o httpencode.o peer.o peerlist.o setnonblock.o bufio.o btstream.o btcontent.o bencode.o bitfield.o btrequest.o connect_nonb.o downloader.o iplist.o rate.o sigint.o btfiles.o btconfig.o

	c++ ${CFLAGS} -o $@ ${LIBS} *.o

.o:
	c++ -c -o $@ ${CFLAGS} $<

install:
	cp ctorrent ${PREFIX}/bin

deinstall:uninstall

uninstall:
	-rm ${PREFIX}/bin/ctorrent

clean:
	-rm *.o
	-rm ctorrent
