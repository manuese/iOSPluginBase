//
//  Plugin.c
//  Unity-iPhone
//
//  Created by Manuel Sena on 10/12/16.
//
//

#import <Foundation/Foundation.h>
#include "Plugin.h"

extern "C" {
    void _fooPluginFunction() {
        NSLog(@"Executing iOS side method.");
    }
    
    void _fooPluginFunctionWithCallback(const char *gameObject, const char *method) {
        UnitySendMessage(gameObject, method, "Sending message to Unity side from iOS side.");
    }
}
