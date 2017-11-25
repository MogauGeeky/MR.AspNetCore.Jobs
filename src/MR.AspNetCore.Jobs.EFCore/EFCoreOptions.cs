﻿namespace MR.AspNetCore.Jobs
{
	public abstract class EFCoreOptions
	{
		public const string DefaultSchema = "Jobs";
		public const string DefaultMigrationsHistoryTableName = "__EFMigrationsHistory";

		/// <summary>
		/// Gets or sets the database's connection string that will be used to store database entities.
		/// </summary>
		public string ConnectionString { get; set; }

		/// <summary>
		/// Gets or sets the schema to use when creating database objects.
		/// Default is <see cref="DefaultSchema"/>.
		/// </summary>
		public string Schema { get; set; } = DefaultSchema;

		/// <summary>
		/// Gets or sets the migrations history table's schema.
		/// If this is null, <see cref="Schema"/> will be used.
		/// </summary>
		public string MigrationsHistoryTableSchema { get; set; }

		/// <summary>
		/// Gets or sets the migrations history table's name.
		/// Default is <see cref="DefaultMigrationsHistoryTableName"/>.
		/// </summary>
		public string MigrationsHistoryTableName { get; set; } = DefaultMigrationsHistoryTableName;
	}
}
