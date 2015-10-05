﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Elasticsearch.Net;
using Elasticsearch.Net.Connection;
using Elasticsearch.Net.Serialization;

namespace Nest
{
	public class Metrics : IUrlParameter
	{
		private readonly Enum _enumValue;

		public string GetString(IConnectionConfigurationValues settings) => KnownEnums.Resolve(this._enumValue);
		internal Metrics(IndicesStatsMetric metric) { _enumValue = metric; }
		internal Metrics(NodesStatsMetric metric){ _enumValue = metric; }
		internal Metrics(NodesInfoMetric metric){ _enumValue = metric; }
		internal Metrics(ClusterStateMetric metric){ _enumValue = metric; }

		public static implicit operator Metrics(IndicesStatsMetric metric) => new Metrics(metric);
		public static implicit operator Metrics(NodesStatsMetric metric) => new Metrics(metric);
		public static implicit operator Metrics(NodesInfoMetric metric) => new Metrics(metric);
		public static implicit operator Metrics(ClusterStateMetric metric) => new Metrics(metric);
	}

	public class IndexMetrics : IUrlParameter
	{
		private readonly Enum _enumValue;

		public string GetString(IConnectionConfigurationValues settings) => KnownEnums.Resolve(this._enumValue);
		internal IndexMetrics(NodesStatsIndexMetric metric) { _enumValue = metric; }

		public static implicit operator IndexMetrics(NodesStatsIndexMetric metric) => new IndexMetrics(metric);
	}

	public class Features : IUrlParameter
	{
		public string GetString(IConnectionConfigurationValues settings)
		{
			throw new NotImplementedException();
		}
	}

	public class Feature : IUrlParameter
	{
		public string GetString(IConnectionConfigurationValues settings)
		{
			throw new NotImplementedException();
		}
	}

	public class PropertyNames : IUrlParameter
	{
		public string GetString(IConnectionConfigurationValues settings)
		{
			throw new NotImplementedException();
		}
	}
}
