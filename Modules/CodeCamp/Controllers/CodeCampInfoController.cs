﻿/*
 * Copyright (c) 2016, Will Strohl
 * All rights reserved.
 * 
 * Redistribution and use in source and binary forms, with or without modification, 
 * are permitted provided that the following conditions are met:
 * 
 * Redistributions of source code must retain the above copyright notice, this list 
 * of conditions and the following disclaimer.
 * 
 * Redistributions in binary form must reproduce the above copyright notice, this 
 * list of conditions and the following disclaimer in the documentation and/or 
 * other materials provided with the distribution.
 * 
 * Neither the name of Will Strohl, nor the names of its contributors may be used 
 * to endorse or promote products derived from this software without specific prior 
 * written permission.
 * 
 * THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" AND 
 * ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED 
 * WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE DISCLAIMED. 
 * IN NO EVENT SHALL THE COPYRIGHT OWNER OR CONTRIBUTORS BE LIABLE FOR ANY DIRECT, 
 * INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, 
 * BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, 
 * DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF 
 * LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE 
 * OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF 
 * ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.
*/

using System.Collections.Generic;
using System.Linq;

namespace WillStrohl.Modules.CodeCamp.Entities
{
    public class CodeCampInfoController
    {
        private readonly CodeCampInfoRepository repo = null;

        public CodeCampInfoController() 
        {
            repo = new CodeCampInfoRepository();
        }

        public void CreateItem(CodeCampInfo i)
        {
            repo.CreateItem(i);
        }

        public void DeleteItem(int itemId, int moduleId)
        {
            repo.DeleteItem(itemId, moduleId);
        }

        public void DeleteItem(CodeCampInfo i)
        {
            repo.DeleteItem(i);
        }

        public IEnumerable<CodeCampInfo> GetItems(int moduleId)
        {
            var items = repo.GetItems(moduleId);
            return items;
        }

        public CodeCampInfo GetItem(int itemId, int moduleId)
        {
            var item = repo.GetItem(itemId, moduleId);
            return item;
        }

        public void UpdateItem(CodeCampInfo i)
        {
            repo.UpdateItem(i);
        }

        public CodeCampInfo GetItemByModuleId(int moduleId)
        {
            var items = GetItems(moduleId);

            return items.FirstOrDefault(i => i.ModuleId == moduleId);
        }
    }
}