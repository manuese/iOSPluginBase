//
//  Plugin.h
//  Unity-iPhone
//
//  Created by Manuel Sena on 10/12/16.
//
//

#ifndef Plugin_h
#define Plugin_h

#include <stdio.h>

#endif /* Plugin_h */

extern "C" {
    void _fooPluginFunction();
    void _fooPluginFunctionWithCallback(const char *gameObject, const char *method);
}
