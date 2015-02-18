/*
*
*
* And then you can just put CHECK_GL_ERR(); all over your code, and it will work nicely.
*
*
*/



#define CHECK_GL_ERR()      ((void) check_opengl_errors(__FILE__, __LINE__))



//------------------------------------------------------------------------------------------------------
static const char * glerror_string(GLenum glerr_code)
{
    switch( glerr_code ) {

    case GL_NO_ERROR:
        return "No error has been recorded."; break;

    case GL_INVALID_ENUM:
        return "An unacceptable value is specified for an enumerated argument. "
                 "The offending command is ignored "
                 "and has no other side effect than to set the error flag."; break;

    case GL_INVALID_VALUE:
        return "A numeric argument is out of range. "
                 "The offending command is ignored "
                 "and has no other side effect than to set the error flag."; break;

    case GL_INVALID_OPERATION:
        return "The specified operation is not allowed in the current state. "
                 "The offending command is ignored "
                 "and has no other side effect than to set the error flag."; break;

    case GL_STACK_OVERFLOW:
        return "This command would cause a stack overflow. "
                 "The offending command is ignored "
                 "and has no other side effect than to set the error flag."; break;

    case GL_STACK_UNDERFLOW:
        return "This command would cause a stack underflow. "
                 "The offending command is ignored "
                 "and has no other side effect than to set the error flag."; break;

    case GL_OUT_OF_MEMORY:
        return "There is not enough memory left to execute the command. "
                 "The state of the GL is undefined, "
                 "except for the state of the error flags, "
                 "after this error is recorded."; break;

    case GL_TABLE_TOO_LARGE:
        return "The specified table exceeds the implementation's maximum supported table "
                 "size. The offending command is ignored and has no other side effect "
                 "than to set the error flag."; break;

    default: break;
    }

    return "Could not find a matching error string.";
}

//------------------------------------------------------------------------------------------------------
static int check_opengl_errors(const char *file, int line)
{
    GLenum glerr;

    glerr = glGetError();
    if (glerr != GL_NO_ERROR)
    {
        printf("glError in file %s @ line %d: %s\n", file, line, glerror_string(glerr));
        return -1;
    }
    return 0;
}
