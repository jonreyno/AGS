#ifndef MAIN_H
#define MAIN_H

#include "plugin/agsplugin.h"

namespace AGS2Client
{
    void AGS_EngineStartup(IAGSEngine *lpEngine);
    void AGS_EngineShutdown();
    int AGS_EngineOnEvent(int event, long data);
    int AGS_EngineDebugHook(const char *scriptName, int lineNum, int reserved);
    void AGS_EngineInitGfx(const char *driverID, void *data);
}

#endif
