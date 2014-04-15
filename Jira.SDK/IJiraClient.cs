﻿using Jira.SDK.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jira.SDK
{
	public interface IJiraClient
	{
		List<Project> GetProjects();
		Project GetProject(String projectKey);

		List<ProjectVersion> GetProjectVersions(String projectKey);

		User GetUser(String username);
		List<User> GetAssignableUsers(String projectKey);

		List<AgileBoard> GetAgileBoards();
		List<Sprint> GetSprintsFromAgileBoard(Int32 agileBoardID);
		List<Issue> GetIssuesFromSprint(Int32 sprintID);

		Issue GetIssue(String key);
		List<Issue> GetIssuesFromProjectVersion(String projectKey, String projectVersionName);
		WorklogSearchResult GetWorkLogs(String issueKey);
	}
}