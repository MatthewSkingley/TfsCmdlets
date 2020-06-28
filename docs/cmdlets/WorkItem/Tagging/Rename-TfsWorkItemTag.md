---
title: Rename-TfsWorkItemTag
breadcrumbs: [ "WorkItem", "Tagging" ]
parent: "WorkItem.Tagging"
description: "Renames a work item tag."
remarks: 
parameterSets: 
  "_All_": [ Collection, NewName, Passthru, Project, Tag ] 
  "__AllParameterSets":  
    Tag: 
      type: "object"  
      position: "0"  
    NewName: 
      type: "string"  
      position: "1"  
      required: true  
    Collection: 
      type: "object"  
    Passthru: 
      type: "SwitchParameter"  
    Project: 
      type: "object" 
parameters: 
  - name: "Tag" 
    description: "Specifies the name of the work item tag to rename." 
    globbing: false 
    pipelineInput: "true (ByValue)" 
    position: 0 
    type: "object" 
    aliases: [ Name ] 
  - name: "Name" 
    description: "Specifies the name of the work item tag to rename.This is an alias of the Tag parameter." 
    globbing: false 
    pipelineInput: "true (ByValue)" 
    position: 0 
    type: "object" 
    aliases: [ Name ] 
  - name: "NewName" 
    description: "Specifies the new name of the item. Enter only a name - i.e., for items that support paths, do not enter a path and name." 
    required: true 
    globbing: false 
    position: 1 
    type: "string" 
  - name: "Project" 
    description: "Specifies the name of the Team Project, its ID (a GUID), or a Microsoft.TeamFoundation.Core.WebApi.TeamProject object to connect to. When omitted, it defaults to the connection set by Connect-TfsTeamProject (if any). For more details, see the Get-TfsTeamProject cmdlet." 
    globbing: false 
    type: "object" 
  - name: "Collection" 
    description: "Specifies the URL to the Team Project Collection or Azure DevOps Organization to connect to, a TfsTeamProjectCollection object (Windows PowerShell only), or a VssConnection object. You can also connect to an Azure DevOps Services organizations by simply providing its name instead of the full URL. For more details, see the Get-TfsTeamProjectCollection cmdlet. When omitted, it defaults to the connection set by Connect-TfsTeamProjectCollection (if any)." 
    globbing: false 
    type: "object" 
  - name: "Passthru" 
    description: "Returns the results of the command. By default, this cmdlet does not generate any output." 
    globbing: false 
    type: "SwitchParameter" 
    defaultValue: "False"
inputs: 
  - type: "System.Object" 
    description: "Specifies the name of the work item tag to rename."
outputs: 
  - type: "Microsoft.TeamFoundation.Core.WebApi.WebApiTagDefinition" 
    description: 
notes: 
relatedLinks: 
  - text: "Online Version:" 
    uri: "https://tfscmdlets.dev/Cmdlets/WorkItem/Tagging/Rename-TfsWorkItemTag"
aliases: 
examples: 
---