#ifndef DEF_H
#define DEF_H

//#define WINDOWS 1	// *** COMMENT THIS LINE IF *NIX */

typedef int ssize_t;
typedef int socklen_t;
typedef unsigned __int64 u_int64_t;
typedef unsigned __int8 u_int8_t;

#define PATH_SP '\\'
#define MAXPATHLEN 1024
#define MAXHOSTNAMELEN 256

//#define mkdir(path,mode) _mkdir((path))

#define snprintf _snprintf
#define strncasecmp _strnicmp
#define strcasecmp _stricmp
#define ioctl ioctlsocket

#define RECV(fd,buf,len) recv((fd),(buf),(len),0)
#define SEND(fd,buf,len) send((fd),(buf),(len),0)
#define EWOULDBLOCK	WSAEWOULDBLOCK
#define EINPROGRESS	WSAEINPROGRESS
#define CLOSE_SOCKET(sk) closesocket((sk))


#endif
