using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace pbxReporter.Data.Asterisk
{
    public partial class asteriskContext : DbContext
    {
        public asteriskContext()
        {
        }

        public asteriskContext(DbContextOptions<asteriskContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Admin> Admin { get; set; }
        public virtual DbSet<Ampusers> Ampusers { get; set; }
        public virtual DbSet<Announcement> Announcement { get; set; }
        public virtual DbSet<Areminder> Areminder { get; set; }
        public virtual DbSet<AreminderCalls> AreminderCalls { get; set; }
        public virtual DbSet<AreminderSettings> AreminderSettings { get; set; }
        public virtual DbSet<Arimanager> Arimanager { get; set; }
        public virtual DbSet<Backup> Backup { get; set; }
        public virtual DbSet<BackupServers> BackupServers { get; set; }
        public virtual DbSet<BackupTemplates> BackupTemplates { get; set; }
        public virtual DbSet<BroadcastCallees> BroadcastCallees { get; set; }
        public virtual DbSet<BroadcastCampaignGroups> BroadcastCampaignGroups { get; set; }
        public virtual DbSet<BroadcastCampaigns> BroadcastCampaigns { get; set; }
        public virtual DbSet<BroadcastGroups> BroadcastGroups { get; set; }
        public virtual DbSet<BroadcastLog> BroadcastLog { get; set; }
        public virtual DbSet<Callback> Callback { get; set; }
        public virtual DbSet<CalleridEntries> CalleridEntries { get; set; }
        public virtual DbSet<Calllimit> Calllimit { get; set; }
        public virtual DbSet<CalllimitUsage> CalllimitUsage { get; set; }
        public virtual DbSet<Callrecording> Callrecording { get; set; }
        public virtual DbSet<CertmanCas> CertmanCas { get; set; }
        public virtual DbSet<CertmanCerts> CertmanCerts { get; set; }
        public virtual DbSet<CertmanCsrs> CertmanCsrs { get; set; }
        public virtual DbSet<CertmanMapping> CertmanMapping { get; set; }
        public virtual DbSet<Cidlookup> Cidlookup { get; set; }
        public virtual DbSet<ContactmanagerEntryEmails> ContactmanagerEntryEmails { get; set; }
        public virtual DbSet<ContactmanagerEntryImages> ContactmanagerEntryImages { get; set; }
        public virtual DbSet<ContactmanagerEntryNumbers> ContactmanagerEntryNumbers { get; set; }
        public virtual DbSet<ContactmanagerEntrySpeeddials> ContactmanagerEntrySpeeddials { get; set; }
        public virtual DbSet<ContactmanagerEntryUsermanImages> ContactmanagerEntryUsermanImages { get; set; }
        public virtual DbSet<ContactmanagerEntryWebsites> ContactmanagerEntryWebsites { get; set; }
        public virtual DbSet<ContactmanagerEntryXmpps> ContactmanagerEntryXmpps { get; set; }
        public virtual DbSet<ContactmanagerGroupEntries> ContactmanagerGroupEntries { get; set; }
        public virtual DbSet<ContactmanagerGroups> ContactmanagerGroups { get; set; }
        public virtual DbSet<Cronmanager> Cronmanager { get; set; }
        public virtual DbSet<CustomExtensions> CustomExtensions { get; set; }
        public virtual DbSet<CxpanelConferenceRooms> CxpanelConferenceRooms { get; set; }
        public virtual DbSet<CxpanelPhoneNumber> CxpanelPhoneNumber { get; set; }
        public virtual DbSet<CxpanelQueues> CxpanelQueues { get; set; }
        public virtual DbSet<CxpanelUsers> CxpanelUsers { get; set; }
        public virtual DbSet<Dahdi> Dahdi { get; set; }
        public virtual DbSet<DahdiAdvanced> DahdiAdvanced { get; set; }
        public virtual DbSet<DahdiAdvancedModules> DahdiAdvancedModules { get; set; }
        public virtual DbSet<Dahdichandids> Dahdichandids { get; set; }
        public virtual DbSet<DahdiSpans> DahdiSpans { get; set; }
        public virtual DbSet<Daynight> Daynight { get; set; }
        public virtual DbSet<DigiumaddoninstallerAddons> DigiumaddoninstallerAddons { get; set; }
        public virtual DbSet<DigiumaddoninstallerAddonsDownloads> DigiumaddoninstallerAddonsDownloads { get; set; }
        public virtual DbSet<DigiumaddoninstallerDownloads> DigiumaddoninstallerDownloads { get; set; }
        public virtual DbSet<DigiumaddoninstallerDownloadsAstVersions> DigiumaddoninstallerDownloadsAstVersions { get; set; }
        public virtual DbSet<DigiumaddoninstallerDownloadsBits> DigiumaddoninstallerDownloadsBits { get; set; }
        public virtual DbSet<DigiumaddoninstallerRegisters> DigiumaddoninstallerRegisters { get; set; }
        public virtual DbSet<DigiumaddoninstallerSystem> DigiumaddoninstallerSystem { get; set; }
        public virtual DbSet<DigiumPhonesAlerts> DigiumPhonesAlerts { get; set; }
        public virtual DbSet<DigiumPhonesCustomapps> DigiumPhonesCustomapps { get; set; }
        public virtual DbSet<DigiumPhonesCustomappSettings> DigiumPhonesCustomappSettings { get; set; }
        public virtual DbSet<DigiumPhonesDeviceAlerts> DigiumPhonesDeviceAlerts { get; set; }
        public virtual DbSet<DigiumPhonesDeviceCustomapps> DigiumPhonesDeviceCustomapps { get; set; }
        public virtual DbSet<DigiumPhonesDeviceExternallines> DigiumPhonesDeviceExternallines { get; set; }
        public virtual DbSet<DigiumPhonesDeviceLogos> DigiumPhonesDeviceLogos { get; set; }
        public virtual DbSet<DigiumPhonesDeviceMcpages> DigiumPhonesDeviceMcpages { get; set; }
        public virtual DbSet<DigiumPhonesDeviceNetworks> DigiumPhonesDeviceNetworks { get; set; }
        public virtual DbSet<DigiumPhonesDeviceParkapps> DigiumPhonesDeviceParkapps { get; set; }
        public virtual DbSet<DigiumPhonesDevicePhonebooks> DigiumPhonesDevicePhonebooks { get; set; }
        public virtual DbSet<DigiumPhonesDeviceRingtones> DigiumPhonesDeviceRingtones { get; set; }
        public virtual DbSet<DigiumPhonesDevices> DigiumPhonesDevices { get; set; }
        public virtual DbSet<DigiumPhonesDeviceSettings> DigiumPhonesDeviceSettings { get; set; }
        public virtual DbSet<DigiumPhonesDeviceStatuses> DigiumPhonesDeviceStatuses { get; set; }
        public virtual DbSet<DigiumPhonesExtensionSettings> DigiumPhonesExtensionSettings { get; set; }
        public virtual DbSet<DigiumPhonesExternallines> DigiumPhonesExternallines { get; set; }
        public virtual DbSet<DigiumPhonesExternallineSettings> DigiumPhonesExternallineSettings { get; set; }
        public virtual DbSet<DigiumPhonesFirmware> DigiumPhonesFirmware { get; set; }
        public virtual DbSet<DigiumPhonesFirmwarePackages> DigiumPhonesFirmwarePackages { get; set; }
        public virtual DbSet<DigiumPhonesGeneral> DigiumPhonesGeneral { get; set; }
        public virtual DbSet<DigiumPhonesLines> DigiumPhonesLines { get; set; }
        public virtual DbSet<DigiumPhonesLogos> DigiumPhonesLogos { get; set; }
        public virtual DbSet<DigiumPhonesMcpages> DigiumPhonesMcpages { get; set; }
        public virtual DbSet<DigiumPhonesMcpageSettings> DigiumPhonesMcpageSettings { get; set; }
        public virtual DbSet<DigiumPhonesNetworks> DigiumPhonesNetworks { get; set; }
        public virtual DbSet<DigiumPhonesNetworkSettings> DigiumPhonesNetworkSettings { get; set; }
        public virtual DbSet<DigiumPhonesPhonebookEntries> DigiumPhonesPhonebookEntries { get; set; }
        public virtual DbSet<DigiumPhonesPhonebookEntrySettings> DigiumPhonesPhonebookEntrySettings { get; set; }
        public virtual DbSet<DigiumPhonesPhonebooks> DigiumPhonesPhonebooks { get; set; }
        public virtual DbSet<DigiumPhonesPnacs> DigiumPhonesPnacs { get; set; }
        public virtual DbSet<DigiumPhonesPnacSettings> DigiumPhonesPnacSettings { get; set; }
        public virtual DbSet<DigiumPhonesQueues> DigiumPhonesQueues { get; set; }
        public virtual DbSet<DigiumPhonesRingtones> DigiumPhonesRingtones { get; set; }
        public virtual DbSet<DigiumPhonesStatusEntries> DigiumPhonesStatusEntries { get; set; }
        public virtual DbSet<DigiumPhonesStatuses> DigiumPhonesStatuses { get; set; }
        public virtual DbSet<DigiumPhonesStatusSettings> DigiumPhonesStatusSettings { get; set; }
        public virtual DbSet<DigiumPhonesVoicemailTranslations> DigiumPhonesVoicemailTranslations { get; set; }
        public virtual DbSet<DirectoryDetails> DirectoryDetails { get; set; }
        public virtual DbSet<Disa> Disa { get; set; }
        public virtual DbSet<EndpointBasefiles> EndpointBasefiles { get; set; }
        public virtual DbSet<EndpointButtons> EndpointButtons { get; set; }
        public virtual DbSet<EndpointExtButtons> EndpointExtButtons { get; set; }
        public virtual DbSet<EndpointExtensions> EndpointExtensions { get; set; }
        public virtual DbSet<EndpointTemplates> EndpointTemplates { get; set; }
        public virtual DbSet<EndpointTimezones> EndpointTimezones { get; set; }
        public virtual DbSet<Extensionroutes> Extensionroutes { get; set; }
        public virtual DbSet<FaxproHookCore> FaxproHookCore { get; set; }
        public virtual DbSet<FaxStore> FaxStore { get; set; }
        public virtual DbSet<Featurecodes> Featurecodes { get; set; }
        public virtual DbSet<Findmefollow> Findmefollow { get; set; }
        public virtual DbSet<FreepbxLog> FreepbxLog { get; set; }
        public virtual DbSet<FreepbxSettings> FreepbxSettings { get; set; }
        public virtual DbSet<Globals> Globals { get; set; }
        public virtual DbSet<Hotelwakeup> Hotelwakeup { get; set; }
        public virtual DbSet<HotelwakeupCalls> HotelwakeupCalls { get; set; }
        public virtual DbSet<Iax> Iax { get; set; }
        public virtual DbSet<Iaxsettings> Iaxsettings { get; set; }
        public virtual DbSet<IndicationsZonelist> IndicationsZonelist { get; set; }
        public virtual DbSet<IvrDetails> IvrDetails { get; set; }
        public virtual DbSet<Kvblobstore> Kvblobstore { get; set; }
        public virtual DbSet<Languages> Languages { get; set; }
        public virtual DbSet<LogfileLogfiles> LogfileLogfiles { get; set; }
        public virtual DbSet<LogfileSettings> LogfileSettings { get; set; }
        public virtual DbSet<Manager> Manager { get; set; }
        public virtual DbSet<Meetme> Meetme { get; set; }
        public virtual DbSet<Miscapps> Miscapps { get; set; }
        public virtual DbSet<Miscdests> Miscdests { get; set; }
        public virtual DbSet<Modules> Modules { get; set; }
        public virtual DbSet<ModuleXml> ModuleXml { get; set; }
        public virtual DbSet<Motif> Motif { get; set; }
        public virtual DbSet<Music> Music { get; set; }
        public virtual DbSet<Notifications> Notifications { get; set; }
        public virtual DbSet<OutboundRoutePatterns> OutboundRoutePatterns { get; set; }
        public virtual DbSet<OutboundRoutes> OutboundRoutes { get; set; }
        public virtual DbSet<OutboundRouteSequence> OutboundRouteSequence { get; set; }
        public virtual DbSet<OutboundRouteTrunks> OutboundRouteTrunks { get; set; }
        public virtual DbSet<Outroutemsg> Outroutemsg { get; set; }
        public virtual DbSet<PagingAutoanswer> PagingAutoanswer { get; set; }
        public virtual DbSet<PagingConfig> PagingConfig { get; set; }
        public virtual DbSet<PagingGroups> PagingGroups { get; set; }
        public virtual DbSet<Pagingpro> Pagingpro { get; set; }
        public virtual DbSet<PagingproCoreRouting> PagingproCoreRouting { get; set; }
        public virtual DbSet<Parkplus> Parkplus { get; set; }
        public virtual DbSet<ParkplusAnnounce> ParkplusAnnounce { get; set; }
        public virtual DbSet<ParkplusDevice> ParkplusDevice { get; set; }
        public virtual DbSet<Pinsets> Pinsets { get; set; }
        public virtual DbSet<PinsetUsage> PinsetUsage { get; set; }
        public virtual DbSet<Pjsip> Pjsip { get; set; }
        public virtual DbSet<PresencestateList> PresencestateList { get; set; }
        public virtual DbSet<PresencestatePrefs> PresencestatePrefs { get; set; }
        public virtual DbSet<QsAgentlog> QsAgentlog { get; set; }
        public virtual DbSet<QsAgentstats> QsAgentstats { get; set; }
        public virtual DbSet<QsCallstats> QsCallstats { get; set; }
        public virtual DbSet<QsLivestats> QsLivestats { get; set; }
        public virtual DbSet<QsQueuestats> QsQueuestats { get; set; }
        public virtual DbSet<Queueprio> Queueprio { get; set; }
        public virtual DbSet<QueuesConfig> QueuesConfig { get; set; }
        public virtual DbSet<QueuesDetails> QueuesDetails { get; set; }
        public virtual DbSet<Recordings> Recordings { get; set; }
        public virtual DbSet<RestappsSettings> RestappsSettings { get; set; }
        public virtual DbSet<Ringgroups> Ringgroups { get; set; }
        public virtual DbSet<SangomacrmRestWebhooks> SangomacrmRestWebhooks { get; set; }
        public virtual DbSet<SangomarcrmSalesforceUsers> SangomarcrmSalesforceUsers { get; set; }
        public virtual DbSet<SangomarcrmSuitecrmUsers> SangomarcrmSuitecrmUsers { get; set; }
        public virtual DbSet<SangomarcrmZohoUsers> SangomarcrmZohoUsers { get; set; }
        public virtual DbSet<Setcid> Setcid { get; set; }
        public virtual DbSet<Sip> Sip { get; set; }
        public virtual DbSet<Sipsettings> Sipsettings { get; set; }
        public virtual DbSet<SmsDids> SmsDids { get; set; }
        public virtual DbSet<SmsMedia> SmsMedia { get; set; }
        public virtual DbSet<SmsMessages> SmsMessages { get; set; }
        public virtual DbSet<SmsRouting> SmsRouting { get; set; }
        public virtual DbSet<SoundlangCustomlangs> SoundlangCustomlangs { get; set; }
        public virtual DbSet<SoundlangPackages> SoundlangPackages { get; set; }
        public virtual DbSet<SoundlangSettings> SoundlangSettings { get; set; }
        public virtual DbSet<Superfectacache> Superfectacache { get; set; }
        public virtual DbSet<Superfectaconfig> Superfectaconfig { get; set; }
        public virtual DbSet<SuperfectaMf> SuperfectaMf { get; set; }
        public virtual DbSet<SuperfectaMfChild> SuperfectaMfChild { get; set; }
        public virtual DbSet<SuperfectaToIncoming> SuperfectaToIncoming { get; set; }
        public virtual DbSet<SysadminUpdateLog> SysadminUpdateLog { get; set; }
        public virtual DbSet<Timeconditions> Timeconditions { get; set; }
        public virtual DbSet<TimegroupsDetails> TimegroupsDetails { get; set; }
        public virtual DbSet<TimegroupsGroups> TimegroupsGroups { get; set; }
        public virtual DbSet<TrunkDialpatterns> TrunkDialpatterns { get; set; }
        public virtual DbSet<Trunks> Trunks { get; set; }
        public virtual DbSet<Tts> Tts { get; set; }
        public virtual DbSet<Ttsengines> Ttsengines { get; set; }
        public virtual DbSet<UcpSessions> UcpSessions { get; set; }
        public virtual DbSet<UsermanDirectories> UsermanDirectories { get; set; }
        public virtual DbSet<UsermanGroups> UsermanGroups { get; set; }
        public virtual DbSet<UsermanUsers> UsermanUsers { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<VirtualQueueConfig> VirtualQueueConfig { get; set; }
        public virtual DbSet<Vmblast> Vmblast { get; set; }
        public virtual DbSet<VmblastGroups> VmblastGroups { get; set; }
        public virtual DbSet<Vmnotify> Vmnotify { get; set; }
        public virtual DbSet<VmnotifyEvents> VmnotifyEvents { get; set; }
        public virtual DbSet<VmnotifyNotifications> VmnotifyNotifications { get; set; }
        public virtual DbSet<VoicemailAdmin> VoicemailAdmin { get; set; }
        public virtual DbSet<VqplusCallbackCalls> VqplusCallbackCalls { get; set; }
        public virtual DbSet<VqplusCallbackConfig> VqplusCallbackConfig { get; set; }
        public virtual DbSet<VqplusCallbackLog> VqplusCallbackLog { get; set; }
        public virtual DbSet<VqplusQruleConfig> VqplusQruleConfig { get; set; }
        public virtual DbSet<VqplusQruleDetail> VqplusQruleDetail { get; set; }
        public virtual DbSet<VqplusQueueConfig> VqplusQueueConfig { get; set; }
        public virtual DbSet<Webcallback> Webcallback { get; set; }
        public virtual DbSet<XmppOptions> XmppOptions { get; set; }
        public virtual DbSet<XmppUsers> XmppUsers { get; set; }
        public virtual DbSet<ZuluSoftphones> ZuluSoftphones { get; set; }
        public virtual DbSet<ZuluTokens> ZuluTokens { get; set; }

        // Unable to generate entity type for table 'areminder_updates'. Please see the warning messages.
        // Unable to generate entity type for table 'backup_cache'. Please see the warning messages.
        // Unable to generate entity type for table 'backup_details'. Please see the warning messages.
        // Unable to generate entity type for table 'backup_items'. Please see the warning messages.
        // Unable to generate entity type for table 'backup_server_details'. Please see the warning messages.
        // Unable to generate entity type for table 'backup_template_details'. Please see the warning messages.
        // Unable to generate entity type for table 'broadcast_settings'. Please see the warning messages.
        // Unable to generate entity type for table 'callrecording_module'. Please see the warning messages.
        // Unable to generate entity type for table 'cidlookup_incoming'. Please see the warning messages.
        // Unable to generate entity type for table 'conferencespro'. Please see the warning messages.
        // Unable to generate entity type for table 'conferencespro_rooms'. Please see the warning messages.
        // Unable to generate entity type for table 'cxpanel_email'. Please see the warning messages.
        // Unable to generate entity type for table 'cxpanel_managed_items'. Please see the warning messages.
        // Unable to generate entity type for table 'cxpanel_recording_agent'. Please see the warning messages.
        // Unable to generate entity type for table 'cxpanel_server'. Please see the warning messages.
        // Unable to generate entity type for table 'cxpanel_voicemail_agent'. Please see the warning messages.
        // Unable to generate entity type for table 'dahdi_analog'. Please see the warning messages.
        // Unable to generate entity type for table 'dahdi_configured_locations'. Please see the warning messages.
        // Unable to generate entity type for table 'dahdi_modules'. Please see the warning messages.
        // Unable to generate entity type for table 'devices'. Please see the warning messages.
        // Unable to generate entity type for table 'directory_entries'. Please see the warning messages.
        // Unable to generate entity type for table 'endpoint_basestations'. Please see the warning messages.
        // Unable to generate entity type for table 'endpoint_brand'. Please see the warning messages.
        // Unable to generate entity type for table 'endpoint_customext'. Please see the warning messages.
        // Unable to generate entity type for table 'endpoint_firmware'. Please see the warning messages.
        // Unable to generate entity type for table 'endpoint_global'. Please see the warning messages.
        // Unable to generate entity type for table 'endpoint_ignoremac'. Please see the warning messages.
        // Unable to generate entity type for table 'endpoint_images'. Please see the warning messages.
        // Unable to generate entity type for table 'endpoint_models'. Please see the warning messages.
        // Unable to generate entity type for table 'endpoint_ringtones'. Please see the warning messages.
        // Unable to generate entity type for table 'endpoint_xml'. Please see the warning messages.
        // Unable to generate entity type for table 'fax_details'. Please see the warning messages.
        // Unable to generate entity type for table 'fax_incoming'. Please see the warning messages.
        // Unable to generate entity type for table 'fax_users'. Please see the warning messages.
        // Unable to generate entity type for table 'incoming'. Please see the warning messages.
        // Unable to generate entity type for table 'ivr_entries'. Please see the warning messages.
        // Unable to generate entity type for table 'kvstore_dashboard'. Please see the warning messages.
        // Unable to generate entity type for table 'kvstore_fax'. Please see the warning messages.
        // Unable to generate entity type for table 'kvstore_freepbx'. Please see the warning messages.
        // Unable to generate entity type for table 'kvstore_freepbx_hooks'. Please see the warning messages.
        // Unable to generate entity type for table 'kvstore_freepbx_media'. Please see the warning messages.
        // Unable to generate entity type for table 'kvstore_freepbx_modules_conferences'. Please see the warning messages.
        // Unable to generate entity type for table 'kvstore_freepbx_modules_core'. Please see the warning messages.
        // Unable to generate entity type for table 'kvstore_freepbx_modules_customappsreg'. Please see the warning messages.
        // Unable to generate entity type for table 'kvstore_freepbx_modules_dahdiconfig'. Please see the warning messages.
        // Unable to generate entity type for table 'kvstore_freepbx_modules_firewall'. Please see the warning messages.
        // Unable to generate entity type for table 'kvstore_freepbx_modules_paging'. Please see the warning messages.
        // Unable to generate entity type for table 'kvstore_freepbx_modules_recording_report'. Please see the warning messages.
        // Unable to generate entity type for table 'kvstore_freepbx_modules_sangomacrm'. Please see the warning messages.
        // Unable to generate entity type for table 'kvstore_freepbx_modules_sipstation'. Please see the warning messages.
        // Unable to generate entity type for table 'kvstore_freepbx_modules_userman'. Please see the warning messages.
        // Unable to generate entity type for table 'kvstore_freepbx_modules_webrtc'. Please see the warning messages.
        // Unable to generate entity type for table 'kvstore_freepbx_realtime'. Please see the warning messages.
        // Unable to generate entity type for table 'kvstore_oobe'. Please see the warning messages.
        // Unable to generate entity type for table 'kvstore_sipsettings'. Please see the warning messages.
        // Unable to generate entity type for table 'language_incoming'. Please see the warning messages.
        // Unable to generate entity type for table 'pagingpro_scheduler_crons'. Please see the warning messages.
        // Unable to generate entity type for table 'pagingpro_scheduler_events'. Please see the warning messages.
        // Unable to generate entity type for table 'pagingpro_scheduler_exclusions'. Please see the warning messages.
        // Unable to generate entity type for table 'pagingpro_scheduler_range'. Please see the warning messages.
        // Unable to generate entity type for table 'prosody'. Please see the warning messages.
        // Unable to generate entity type for table 'queuemetrics_options'. Please see the warning messages.
        // Unable to generate entity type for table 'recording_report'. Please see the warning messages.
        // Unable to generate entity type for table 'restapi_general'. Please see the warning messages.
        // Unable to generate entity type for table 'restapi_log_event_details'. Please see the warning messages.
        // Unable to generate entity type for table 'restapi_log_events'. Please see the warning messages.
        // Unable to generate entity type for table 'restapi_token_details'. Please see the warning messages.
        // Unable to generate entity type for table 'restapi_token_user_mapping'. Please see the warning messages.
        // Unable to generate entity type for table 'restapi_tokens'. Please see the warning messages.
        // Unable to generate entity type for table 'restapps_stats'. Please see the warning messages.
        // Unable to generate entity type for table 'sangomacrm_rest_rows'. Please see the warning messages.
        // Unable to generate entity type for table 'soundlang_prompts'. Please see the warning messages.
        // Unable to generate entity type for table 'sysadmin_options'. Please see the warning messages.
        // Unable to generate entity type for table 'userman_groups_settings'. Please see the warning messages.
        // Unable to generate entity type for table 'userman_users_settings'. Please see the warning messages.
        // Unable to generate entity type for table 'webrtc_clients'. Please see the warning messages.

     

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Admin>(entity =>
            {
                entity.HasKey(e => e.Variable);

                entity.ToTable("admin");

                entity.Property(e => e.Variable)
                    .HasColumnName("variable")
                    .HasColumnType("varchar(20)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasColumnName("value")
                    .HasColumnType("varchar(80)")
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<Ampusers>(entity =>
            {
                entity.HasKey(e => e.Username);

                entity.ToTable("ampusers");

                entity.Property(e => e.Username)
                    .HasColumnName("username")
                    .HasColumnType("varchar(190)");

                entity.Property(e => e.Deptname)
                    .IsRequired()
                    .HasColumnName("deptname")
                    .HasColumnType("varchar(20)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ExtensionHigh)
                    .IsRequired()
                    .HasColumnName("extension_high")
                    .HasColumnType("varchar(20)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ExtensionLow)
                    .IsRequired()
                    .HasColumnName("extension_low")
                    .HasColumnType("varchar(20)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.PasswordSha1)
                    .IsRequired()
                    .HasColumnName("password_sha1")
                    .HasColumnType("varchar(40)");

                entity.Property(e => e.Sections)
                    .IsRequired()
                    .HasColumnName("sections");
            });

            modelBuilder.Entity<Announcement>(entity =>
            {
                entity.ToTable("announcement");

                entity.Property(e => e.AnnouncementId)
                    .HasColumnName("announcement_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AllowSkip)
                    .HasColumnName("allow_skip")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.Noanswer)
                    .HasColumnName("noanswer")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.PostDest)
                    .HasColumnName("post_dest")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.RecordingId)
                    .HasColumnName("recording_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.RepeatMsg)
                    .IsRequired()
                    .HasColumnName("repeat_msg")
                    .HasColumnType("varchar(2)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ReturnIvr)
                    .HasColumnName("return_ivr")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<Areminder>(entity =>
            {
                entity.ToTable("areminder");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Attachas)
                    .IsRequired()
                    .HasColumnName("attachas")
                    .HasColumnType("varchar(4)")
                    .HasDefaultValueSql("'CSV'");

                entity.Property(e => e.Cidtype)
                    .IsRequired()
                    .HasColumnName("cidtype")
                    .HasColumnType("varchar(24)")
                    .HasDefaultValueSql("'default'");

                entity.Property(e => e.Csext)
                    .IsRequired()
                    .HasColumnName("csext")
                    .HasColumnType("varchar(64)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Emailcomplete)
                    .IsRequired()
                    .HasColumnName("emailcomplete")
                    .HasColumnType("text");

                entity.Property(e => e.Emailfrom)
                    .IsRequired()
                    .HasColumnName("emailfrom")
                    .HasColumnType("text");

                entity.Property(e => e.Enabled)
                    .HasColumnName("enabled")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Greeting2id)
                    .HasColumnName("greeting2id")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Greetingid)
                    .HasColumnName("greetingid")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Instructionsid)
                    .HasColumnName("instructionsid")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Lastemail)
                    .HasColumnName("lastemail")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Maxnotice)
                    .HasColumnName("maxnotice")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("varchar(64)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Outcid)
                    .IsRequired()
                    .HasColumnName("outcid")
                    .HasColumnType("varchar(56)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Outcidname)
                    .IsRequired()
                    .HasColumnName("outcidname")
                    .HasColumnType("varchar(56)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Resched)
                    .IsRequired()
                    .HasColumnName("resched")
                    .HasColumnType("varchar(4)")
                    .HasDefaultValueSql("'LOG'");

                entity.Property(e => e.Retrycount)
                    .HasColumnName("retrycount")
                    .HasDefaultValueSql("'3'");

                entity.Property(e => e.Retrydelay)
                    .HasColumnName("retrydelay")
                    .HasDefaultValueSql("'300'");

                entity.Property(e => e.Saydate)
                    .HasColumnName("saydate")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Sayname)
                    .HasColumnName("sayname")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Schedext)
                    .IsRequired()
                    .HasColumnName("schedext")
                    .HasColumnType("varchar(64)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Start1)
                    .HasColumnName("start1")
                    .HasColumnType("int(10)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Start2)
                    .HasColumnName("start2")
                    .HasColumnType("int(10)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Start3)
                    .HasColumnName("start3")
                    .HasColumnType("int(10)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Start4)
                    .HasColumnName("start4")
                    .HasColumnType("int(10)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Start5)
                    .HasColumnName("start5")
                    .HasColumnType("int(10)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Start6)
                    .HasColumnName("start6")
                    .HasColumnType("int(10)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Start7)
                    .HasColumnName("start7")
                    .HasColumnType("int(10)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Stop1)
                    .HasColumnName("stop1")
                    .HasColumnType("int(10)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Stop2)
                    .HasColumnName("stop2")
                    .HasColumnType("int(10)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Stop3)
                    .HasColumnName("stop3")
                    .HasColumnType("int(10)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Stop4)
                    .HasColumnName("stop4")
                    .HasColumnType("int(10)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Stop5)
                    .HasColumnName("stop5")
                    .HasColumnType("int(10)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Stop6)
                    .HasColumnName("stop6")
                    .HasColumnType("int(10)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Stop7)
                    .HasColumnName("stop7")
                    .HasColumnType("int(10)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Ttsengine)
                    .HasColumnName("ttsengine")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'1'");
            });

            modelBuilder.Entity<AreminderCalls>(entity =>
            {
                entity.ToTable("areminder_calls");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Appointment)
                    .HasColumnName("appointment")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Arid)
                    .HasColumnName("arid")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Calltime)
                    .HasColumnName("calltime")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Length)
                    .HasColumnName("length")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("varchar(64)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Notes)
                    .HasColumnName("notes")
                    .HasColumnType("varchar(512)");

                entity.Property(e => e.Number)
                    .IsRequired()
                    .HasColumnName("number")
                    .HasColumnType("varchar(24)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Retry)
                    .HasColumnName("retry")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<AreminderSettings>(entity =>
            {
                entity.ToTable("areminder_settings");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Key)
                    .IsRequired()
                    .HasColumnName("key")
                    .HasColumnType("varchar(64)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasColumnName("value")
                    .HasColumnType("varchar(64)")
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<Arimanager>(entity =>
            {
                entity.ToTable("arimanager");

                entity.HasIndex(e => e.Name)
                    .HasName("name_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("varchar(15)");

                entity.Property(e => e.Password)
                    .HasColumnName("password")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.PasswordFormat)
                    .HasColumnName("password_format")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.ReadOnly)
                    .HasColumnName("read_only")
                    .HasColumnType("int(1)")
                    .HasDefaultValueSql("'1'");
            });

            modelBuilder.Entity<Backup>(entity =>
            {
                entity.ToTable("backup");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Data)
                    .HasColumnName("data")
                    .HasColumnType("longtext");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasColumnType("longtext");

                entity.Property(e => e.Immortal)
                    .HasColumnName("immortal")
                    .HasColumnType("varchar(25)");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<BackupServers>(entity =>
            {
                entity.ToTable("backup_servers");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Data)
                    .HasColumnName("data")
                    .HasColumnType("longtext");

                entity.Property(e => e.Desc)
                    .HasColumnName("desc")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.Immortal)
                    .HasColumnName("immortal")
                    .HasColumnType("varchar(25)");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.Readonly)
                    .HasColumnName("readonly")
                    .HasColumnType("varchar(250)");

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<BackupTemplates>(entity =>
            {
                entity.ToTable("backup_templates");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Data)
                    .HasColumnName("data")
                    .HasColumnType("longtext");

                entity.Property(e => e.Desc)
                    .HasColumnName("desc")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.Immortal)
                    .HasColumnName("immortal")
                    .HasColumnType("varchar(25)");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<BroadcastCallees>(entity =>
            {
                entity.ToTable("broadcast_callees");

                entity.HasIndex(e => e.GroupId)
                    .HasName("broadcast_callees_group_id");

                entity.HasIndex(e => e.Name)
                    .HasName("name");

                entity.HasIndex(e => e.Phonenum)
                    .HasName("phonenum");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("mediumint(9)");

                entity.Property(e => e.GroupId)
                    .HasColumnName("group_id")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("varchar(40)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Phonenum)
                    .IsRequired()
                    .HasColumnName("phonenum")
                    .HasColumnType("varchar(20)")
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<BroadcastCampaignGroups>(entity =>
            {
                entity.ToTable("broadcast_campaign_groups");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("mediumint(9)");

                entity.Property(e => e.CampaignId)
                    .HasColumnName("campaign_id")
                    .HasColumnType("mediumint(9)");

                entity.Property(e => e.GroupId)
                    .HasColumnName("group_id")
                    .HasColumnType("mediumint(9)");
            });

            modelBuilder.Entity<BroadcastCampaigns>(entity =>
            {
                entity.ToTable("broadcast_campaigns");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Active)
                    .HasColumnName("active")
                    .HasColumnType("tinyint(4)");

                entity.Property(e => e.Callerid)
                    .IsRequired()
                    .HasColumnName("callerid")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.Completed)
                    .HasColumnName("completed")
                    .HasColumnType("tinyint(4)");

                entity.Property(e => e.Concurrentcalls)
                    .HasColumnName("concurrentcalls")
                    .HasColumnType("int(1)")
                    .HasDefaultValueSql("'2'");

                entity.Property(e => e.DateFinish)
                    .HasColumnName("date_finish")
                    .HasColumnType("date");

                entity.Property(e => e.DateStart)
                    .HasColumnName("date_start")
                    .HasColumnType("date");

                entity.Property(e => e.DestinationMachine)
                    .IsRequired()
                    .HasColumnName("destination_machine")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.DestinationPerson)
                    .IsRequired()
                    .HasColumnName("destination_person")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.Dupes)
                    .HasColumnName("dupes")
                    .HasColumnType("int(1)")
                    .HasDefaultValueSql("'2'");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("email")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.EmailSettings)
                    .IsRequired()
                    .HasColumnName("email_settings")
                    .HasColumnType("varchar(64)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Prefix)
                    .HasColumnName("prefix")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Retries)
                    .HasColumnName("retries")
                    .HasColumnType("int(1)")
                    .HasDefaultValueSql("'2'");

                entity.Property(e => e.TimeFinish)
                    .HasColumnName("time_finish")
                    .HasColumnType("time");

                entity.Property(e => e.TimeStart)
                    .HasColumnName("time_start")
                    .HasColumnType("time");

                entity.Property(e => e.Uniqueid)
                    .HasColumnName("uniqueid")
                    .HasColumnType("char(64)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.WeekdayFinish)
                    .HasColumnName("weekday_finish")
                    .HasColumnType("int(1)");

                entity.Property(e => e.WeekdayStart)
                    .HasColumnName("weekday_start")
                    .HasColumnType("int(1)");
            });

            modelBuilder.Entity<BroadcastGroups>(entity =>
            {
                entity.ToTable("broadcast_groups");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("mediumint(9)");

                entity.Property(e => e.Csvformat)
                    .HasColumnName("csvformat")
                    .HasColumnType("char(4)")
                    .HasDefaultValueSql("'ABC'");

                entity.Property(e => e.Ftpdelete)
                    .HasColumnName("ftpdelete")
                    .HasColumnType("int(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Lastupdate)
                    .HasColumnName("lastupdate")
                    .HasDefaultValueSql("'140000000'");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.Update)
                    .HasColumnName("update")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'300'");

                entity.Property(e => e.Uri)
                    .HasColumnName("uri")
                    .HasColumnType("char(255)");
            });

            modelBuilder.Entity<BroadcastLog>(entity =>
            {
                entity.ToTable("broadcast_log");

                entity.HasIndex(e => e.Callee)
                    .HasName("broadcast_log_callee");

                entity.HasIndex(e => e.CampaignId)
                    .HasName("broadcast_log_campaign_id");

                entity.HasIndex(e => e.Uniqueid)
                    .HasName("broadcast_log_uniqueid");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("mediumint(9)");

                entity.Property(e => e.Answer)
                    .HasColumnName("answer")
                    .HasColumnType("tinyint(4)");

                entity.Property(e => e.Attempt)
                    .HasColumnName("attempt")
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Callee)
                    .HasColumnName("callee")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Callid)
                    .IsRequired()
                    .HasColumnName("callid")
                    .HasColumnType("varchar(32)");

                entity.Property(e => e.CampaignId)
                    .HasColumnName("campaign_id")
                    .HasColumnType("mediumint(9)");

                entity.Property(e => e.CampaignName)
                    .IsRequired()
                    .HasColumnName("campaign_name")
                    .HasColumnType("char(64)");

                entity.Property(e => e.DeliveredTo)
                    .IsRequired()
                    .HasColumnName("delivered_to")
                    .HasColumnType("varchar(32)");

                entity.Property(e => e.Dialedname)
                    .HasColumnName("dialedname")
                    .HasColumnType("char(64)");

                entity.Property(e => e.Dialednum)
                    .HasColumnName("dialednum")
                    .HasColumnType("char(64)");

                entity.Property(e => e.InitiatedDial)
                    .HasColumnName("initiated_dial")
                    .HasColumnType("tinyint(4)");

                entity.Property(e => e.LastUpdated)
                    .HasColumnName("last_updated")
                    .HasColumnType("datetime");

                entity.Property(e => e.Uniqueid)
                    .HasColumnName("uniqueid")
                    .HasColumnType("char(64)");
            });

            modelBuilder.Entity<Callback>(entity =>
            {
                entity.ToTable("callback");

                entity.Property(e => e.CallbackId)
                    .HasColumnName("callback_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Callbacknum)
                    .HasColumnName("callbacknum")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.Deptname)
                    .HasColumnName("deptname")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.Destination)
                    .HasColumnName("destination")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.Sleep)
                    .HasColumnName("sleep")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<CalleridEntries>(entity =>
            {
                entity.ToTable("callerid_entries");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Cidname)
                    .HasColumnName("cidname")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.Cidnum)
                    .HasColumnName("cidnum")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.Perm)
                    .HasColumnName("perm")
                    .HasColumnType("varchar(25)");

                entity.Property(e => e.Prefix)
                    .HasColumnName("prefix")
                    .HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<Calllimit>(entity =>
            {
                entity.HasKey(e => e.Key);

                entity.ToTable("calllimit");

                entity.Property(e => e.Key)
                    .HasColumnName("key")
                    .HasColumnType("char(64)");

                entity.Property(e => e.Value)
                    .HasColumnName("value")
                    .HasColumnType("varchar(64)");
            });

            modelBuilder.Entity<CalllimitUsage>(entity =>
            {
                entity.HasKey(e => new { e.Dispname, e.ForeignId });

                entity.ToTable("calllimit_usage");

                entity.Property(e => e.Dispname)
                    .HasColumnName("dispname")
                    .HasColumnType("varchar(30)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ForeignId)
                    .HasColumnName("foreign_id")
                    .HasColumnType("varchar(30)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CalllimitId)
                    .HasColumnName("calllimit_id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<Callrecording>(entity =>
            {
                entity.ToTable("callrecording");

                entity.Property(e => e.CallrecordingId)
                    .HasColumnName("callrecording_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CallrecordingMode)
                    .HasColumnName("callrecording_mode")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.Dest)
                    .HasColumnName("dest")
                    .HasColumnType("varchar(255)");
            });

            modelBuilder.Entity<CertmanCas>(entity =>
            {
                entity.HasKey(e => e.Uid);

                entity.ToTable("certman_cas");

                entity.HasIndex(e => e.Basename)
                    .HasName("basename")
                    .IsUnique();

                entity.Property(e => e.Uid)
                    .HasColumnName("uid")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Basename)
                    .IsRequired()
                    .HasColumnName("basename")
                    .HasColumnType("varchar(190)");

                entity.Property(e => e.Cn)
                    .IsRequired()
                    .HasColumnName("cn")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.On)
                    .IsRequired()
                    .HasColumnName("on")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.Passphrase)
                    .HasColumnName("passphrase")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.Salt)
                    .HasColumnName("salt")
                    .HasColumnType("varchar(255)");
            });

            modelBuilder.Entity<CertmanCerts>(entity =>
            {
                entity.HasKey(e => e.Cid);

                entity.ToTable("certman_certs");

                entity.HasIndex(e => e.Basename)
                    .HasName("basename_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.Cid)
                    .HasColumnName("cid")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Additional).HasColumnName("additional");

                entity.Property(e => e.Basename)
                    .IsRequired()
                    .HasColumnName("basename")
                    .HasColumnType("varchar(190)");

                entity.Property(e => e.Caid)
                    .HasColumnName("caid")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Default)
                    .HasColumnName("default")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasColumnName("type")
                    .HasColumnType("varchar(2)")
                    .HasDefaultValueSql("'ss'");
            });

            modelBuilder.Entity<CertmanCsrs>(entity =>
            {
                entity.HasKey(e => e.Cid);

                entity.ToTable("certman_csrs");

                entity.HasIndex(e => e.Basename)
                    .HasName("basename")
                    .IsUnique();

                entity.Property(e => e.Cid)
                    .HasColumnName("cid")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Basename)
                    .IsRequired()
                    .HasColumnName("basename")
                    .HasColumnType("varchar(190)");
            });

            modelBuilder.Entity<CertmanMapping>(entity =>
            {
                entity.ToTable("certman_mapping");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Cid)
                    .HasColumnName("cid")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Rekey)
                    .HasColumnName("rekey")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Setup)
                    .HasColumnName("setup")
                    .HasColumnType("varchar(45)");

                entity.Property(e => e.Verify)
                    .HasColumnName("verify")
                    .HasColumnType("varchar(255)");
            });

            modelBuilder.Entity<Cidlookup>(entity =>
            {
                entity.ToTable("cidlookup");

                entity.Property(e => e.CidlookupId)
                    .HasColumnName("cidlookup_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Cache)
                    .HasColumnName("cache")
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.CmFormat)
                    .HasColumnName("cm_format")
                    .HasColumnType("varchar(5)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CmGroup)
                    .HasColumnName("cm_group")
                    .HasColumnType("varchar(60)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Deptname)
                    .HasColumnName("deptname")
                    .HasColumnType("varchar(30)");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.HttpHost)
                    .HasColumnName("http_host")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.HttpPassword)
                    .HasColumnName("http_password")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.HttpPath)
                    .HasColumnName("http_path")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.HttpPort)
                    .HasColumnName("http_port")
                    .HasColumnType("varchar(30)");

                entity.Property(e => e.HttpQuery)
                    .HasColumnName("http_query")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.HttpUsername)
                    .HasColumnName("http_username")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.MysqlCharset)
                    .HasColumnName("mysql_charset")
                    .HasColumnType("varchar(60)");

                entity.Property(e => e.MysqlDbname)
                    .HasColumnName("mysql_dbname")
                    .HasColumnType("varchar(60)");

                entity.Property(e => e.MysqlHost)
                    .HasColumnName("mysql_host")
                    .HasColumnType("varchar(60)");

                entity.Property(e => e.MysqlPassword)
                    .HasColumnName("mysql_password")
                    .HasColumnType("varchar(30)");

                entity.Property(e => e.MysqlQuery)
                    .HasColumnName("mysql_query")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.MysqlUsername)
                    .HasColumnName("mysql_username")
                    .HasColumnType("varchar(30)");

                entity.Property(e => e.OpencnamAccountSid)
                    .HasColumnName("opencnam_account_sid")
                    .HasColumnType("varchar(34)");

                entity.Property(e => e.OpencnamAuthToken)
                    .HasColumnName("opencnam_auth_token")
                    .HasColumnType("varchar(34)");

                entity.Property(e => e.Sourcetype)
                    .IsRequired()
                    .HasColumnName("sourcetype")
                    .HasColumnType("varchar(100)");
            });

            modelBuilder.Entity<ContactmanagerEntryEmails>(entity =>
            {
                entity.ToTable("contactmanager_entry_emails");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.Entryid)
                    .HasColumnName("entryid")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<ContactmanagerEntryImages>(entity =>
            {
                entity.HasKey(e => e.Entryid);

                entity.ToTable("contactmanager_entry_images");

                entity.Property(e => e.Entryid)
                    .HasColumnName("entryid")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Format)
                    .IsRequired()
                    .HasColumnName("format")
                    .HasColumnType("varchar(45)");

                entity.Property(e => e.Gravatar)
                    .HasColumnName("gravatar")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Image).HasColumnName("image");
            });

            modelBuilder.Entity<ContactmanagerEntryNumbers>(entity =>
            {
                entity.ToTable("contactmanager_entry_numbers");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Entryid)
                    .HasColumnName("entryid")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Extension)
                    .HasColumnName("extension")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.Flags)
                    .HasColumnName("flags")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.Number)
                    .HasColumnName("number")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasColumnType("varchar(100)");
            });

            modelBuilder.Entity<ContactmanagerEntrySpeeddials>(entity =>
            {
                entity.ToTable("contactmanager_entry_speeddials");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Entryid)
                    .HasColumnName("entryid")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Numberid)
                    .HasColumnName("numberid")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<ContactmanagerEntryUsermanImages>(entity =>
            {
                entity.HasKey(e => e.Uid);

                entity.ToTable("contactmanager_entry_userman_images");

                entity.Property(e => e.Uid)
                    .HasColumnName("uid")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Format)
                    .IsRequired()
                    .HasColumnName("format")
                    .HasColumnType("varchar(45)");

                entity.Property(e => e.Gravatar)
                    .HasColumnName("gravatar")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Image).HasColumnName("image");
            });

            modelBuilder.Entity<ContactmanagerEntryWebsites>(entity =>
            {
                entity.ToTable("contactmanager_entry_websites");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Entryid)
                    .HasColumnName("entryid")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Website)
                    .HasColumnName("website")
                    .HasColumnType("varchar(100)");
            });

            modelBuilder.Entity<ContactmanagerEntryXmpps>(entity =>
            {
                entity.ToTable("contactmanager_entry_xmpps");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Entryid)
                    .HasColumnName("entryid")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Xmpp)
                    .HasColumnName("xmpp")
                    .HasColumnType("varchar(100)");
            });

            modelBuilder.Entity<ContactmanagerGroupEntries>(entity =>
            {
                entity.ToTable("contactmanager_group_entries");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Address)
                    .HasColumnName("address")
                    .HasColumnType("varchar(200)");

                entity.Property(e => e.Company)
                    .HasColumnName("company")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.Displayname)
                    .HasColumnName("displayname")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.Fname)
                    .HasColumnName("fname")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.Groupid)
                    .HasColumnName("groupid")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Lname)
                    .HasColumnName("lname")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.Title)
                    .HasColumnName("title")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.User)
                    .HasColumnName("user")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Uuid)
                    .HasColumnName("uuid")
                    .HasColumnType("varchar(36)");
            });

            modelBuilder.Entity<ContactmanagerGroups>(entity =>
            {
                entity.ToTable("contactmanager_groups");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("varchar(80)");

                entity.Property(e => e.Owner)
                    .HasColumnName("owner")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasColumnName("type")
                    .HasColumnType("varchar(25)");
            });

            modelBuilder.Entity<Cronmanager>(entity =>
            {
                entity.HasKey(e => new { e.Module, e.Id });

                entity.ToTable("cronmanager");

                entity.Property(e => e.Module)
                    .HasColumnName("module")
                    .HasColumnType("varchar(24)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("varchar(24)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Command)
                    .IsRequired()
                    .HasColumnName("command")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Freq)
                    .HasColumnName("freq")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Lasttime)
                    .HasColumnName("lasttime")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Time)
                    .HasColumnName("time")
                    .HasColumnType("varchar(5)");
            });

            modelBuilder.Entity<CustomExtensions>(entity =>
            {
                entity.HasKey(e => e.CustomExten);

                entity.ToTable("custom_extensions");

                entity.Property(e => e.CustomExten)
                    .HasColumnName("custom_exten")
                    .HasColumnType("varchar(80)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description")
                    .HasColumnType("varchar(40)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Notes)
                    .IsRequired()
                    .HasColumnName("notes")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<CxpanelConferenceRooms>(entity =>
            {
                entity.HasKey(e => e.CxpanelConferenceRoomId);

                entity.ToTable("cxpanel_conference_rooms");

                entity.HasIndex(e => e.ConferenceRoomId)
                    .HasName("conference_room_id")
                    .IsUnique();

                entity.Property(e => e.CxpanelConferenceRoomId)
                    .HasColumnName("cxpanel_conference_room_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AddConferenceRoom)
                    .HasColumnName("add_conference_room")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ConferenceRoomId)
                    .IsRequired()
                    .HasColumnName("conference_room_id")
                    .HasColumnType("varchar(190)");

                entity.Property(e => e.DisplayName)
                    .IsRequired()
                    .HasColumnName("display_name")
                    .HasColumnType("varchar(1000)");
            });

            modelBuilder.Entity<CxpanelPhoneNumber>(entity =>
            {
                entity.ToTable("cxpanel_phone_number");

                entity.Property(e => e.CxpanelPhoneNumberId)
                    .HasColumnName("cxpanel_phone_number_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PhoneNumber)
                    .IsRequired()
                    .HasColumnName("phone_number")
                    .HasColumnType("varchar(1000)");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasColumnName("type")
                    .HasColumnType("varchar(1000)");

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasColumnName("user_id")
                    .HasColumnType("varchar(1000)");
            });

            modelBuilder.Entity<CxpanelQueues>(entity =>
            {
                entity.HasKey(e => e.CxpanelQueueId);

                entity.ToTable("cxpanel_queues");

                entity.HasIndex(e => e.QueueId)
                    .HasName("queue_id")
                    .IsUnique();

                entity.Property(e => e.CxpanelQueueId)
                    .HasColumnName("cxpanel_queue_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AddQueue)
                    .HasColumnName("add_queue")
                    .HasColumnType("int(11)");

                entity.Property(e => e.DisplayName)
                    .IsRequired()
                    .HasColumnName("display_name")
                    .HasColumnType("varchar(1000)");

                entity.Property(e => e.QueueId)
                    .IsRequired()
                    .HasColumnName("queue_id")
                    .HasColumnType("varchar(190)");
            });

            modelBuilder.Entity<CxpanelUsers>(entity =>
            {
                entity.HasKey(e => e.CxpanelUserId);

                entity.ToTable("cxpanel_users");

                entity.HasIndex(e => e.UserId)
                    .HasName("user_id")
                    .IsUnique();

                entity.Property(e => e.CxpanelUserId)
                    .HasColumnName("cxpanel_user_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AddExtension)
                    .HasColumnName("add_extension")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AddUser)
                    .HasColumnName("add_user")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AutoAnswer)
                    .HasColumnName("auto_answer")
                    .HasColumnType("int(11)");

                entity.Property(e => e.DisplayName)
                    .IsRequired()
                    .HasColumnName("display_name")
                    .HasColumnType("varchar(1000)");

                entity.Property(e => e.Full)
                    .HasColumnName("full")
                    .HasColumnType("int(11)");

                entity.Property(e => e.HashedPassword)
                    .IsRequired()
                    .HasColumnName("hashed_password")
                    .HasColumnType("varchar(1000)");

                entity.Property(e => e.InitialPassword)
                    .IsRequired()
                    .HasColumnName("initial_password")
                    .HasColumnType("varchar(1000)");

                entity.Property(e => e.ParentUserId)
                    .IsRequired()
                    .HasColumnName("parent_user_id")
                    .HasColumnType("varchar(1000)");

                entity.Property(e => e.PasswordDirty)
                    .HasColumnName("password_dirty")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Peer)
                    .IsRequired()
                    .HasColumnName("peer")
                    .HasColumnType("varchar(1000)");

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasColumnName("user_id")
                    .HasColumnType("varchar(190)");
            });

            modelBuilder.Entity<Dahdi>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.Keyword });

                entity.ToTable("dahdi");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("varchar(20)")
                    .HasDefaultValueSql("'-1'");

                entity.Property(e => e.Keyword)
                    .HasColumnName("keyword")
                    .HasColumnType("varchar(30)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Data)
                    .IsRequired()
                    .HasColumnName("data")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Flags)
                    .HasColumnName("flags")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<DahdiAdvanced>(entity =>
            {
                entity.HasKey(e => e.Keyword);

                entity.ToTable("dahdi_advanced");

                entity.Property(e => e.Keyword)
                    .HasColumnName("keyword")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.Additional)
                    .HasColumnName("additional")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.DefaultVal)
                    .HasColumnName("default_val")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("'chandahdi'");

                entity.Property(e => e.Val)
                    .HasColumnName("val")
                    .HasColumnType("varchar(255)");
            });

            modelBuilder.Entity<DahdiAdvancedModules>(entity =>
            {
                entity.ToTable("dahdi_advanced_modules");

                entity.HasIndex(e => e.ModuleName)
                    .HasName("module_name")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ModuleName)
                    .HasColumnName("module_name")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.Settings)
                    .HasColumnName("settings")
                    .HasColumnType("blob");
            });

            modelBuilder.Entity<Dahdichandids>(entity =>
            {
                entity.HasKey(e => e.Channel);

                entity.ToTable("dahdichandids");

                entity.Property(e => e.Channel)
                    .HasColumnName("channel")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description")
                    .HasColumnType("varchar(40)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Did)
                    .IsRequired()
                    .HasColumnName("did")
                    .HasColumnType("varchar(60)")
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<DahdiSpans>(entity =>
            {
                entity.ToTable("dahdi_spans");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Active)
                    .HasColumnName("active")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.AdditionalGroups).HasColumnName("additional_groups");

                entity.Property(e => e.Alarms)
                    .HasColumnName("alarms")
                    .HasColumnType("varchar(15)");

                entity.Property(e => e.Basechan)
                    .HasColumnName("basechan")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Coding)
                    .HasColumnName("coding")
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.CodingOpts)
                    .HasColumnName("coding_opts")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.Context)
                    .HasColumnName("context")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.Definedchans)
                    .HasColumnName("definedchans")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.Devicetype)
                    .HasColumnName("devicetype")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.Framing)
                    .HasColumnName("framing")
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.FramingOpts)
                    .HasColumnName("framing_opts")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.Group)
                    .HasColumnName("group")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Irq)
                    .HasColumnName("irq")
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.Lbo)
                    .HasColumnName("lbo")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Location)
                    .HasColumnName("location")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.Manufacturer)
                    .IsRequired()
                    .HasColumnName("manufacturer")
                    .HasColumnType("varchar(25)")
                    .HasDefaultValueSql("'Digium'");

                entity.Property(e => e.MaxCh)
                    .HasColumnName("max_ch")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Mfcr2AcceptOnOffer)
                    .IsRequired()
                    .HasColumnName("mfcr2_accept_on_offer")
                    .HasColumnType("varchar(3)")
                    .HasDefaultValueSql("'yes'");

                entity.Property(e => e.Mfcr2AdvancedProtocolFile)
                    .HasColumnName("mfcr2_advanced_protocol_file")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.Mfcr2AllowCollectCalls)
                    .IsRequired()
                    .HasColumnName("mfcr2_allow_collect_calls")
                    .HasColumnType("varchar(3)")
                    .HasDefaultValueSql("'no'");

                entity.Property(e => e.Mfcr2CallFiles)
                    .IsRequired()
                    .HasColumnName("mfcr2_call_files")
                    .HasColumnType("varchar(3)")
                    .HasDefaultValueSql("'yes'");

                entity.Property(e => e.Mfcr2Category)
                    .IsRequired()
                    .HasColumnName("mfcr2_category")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("'national_subscriber'");

                entity.Property(e => e.Mfcr2ChargeCalls)
                    .IsRequired()
                    .HasColumnName("mfcr2_charge_calls")
                    .HasColumnType("varchar(3)")
                    .HasDefaultValueSql("'yes'");

                entity.Property(e => e.Mfcr2DoubleAnswer)
                    .IsRequired()
                    .HasColumnName("mfcr2_double_answer")
                    .HasColumnType("varchar(3)")
                    .HasDefaultValueSql("'no'");

                entity.Property(e => e.Mfcr2ForcedRelease)
                    .IsRequired()
                    .HasColumnName("mfcr2_forced_release")
                    .HasColumnType("varchar(3)")
                    .HasDefaultValueSql("'no'");

                entity.Property(e => e.Mfcr2GetAniFirst)
                    .IsRequired()
                    .HasColumnName("mfcr2_get_ani_first")
                    .HasColumnType("varchar(3)")
                    .HasDefaultValueSql("'no'");

                entity.Property(e => e.Mfcr2ImmediateAccept)
                    .IsRequired()
                    .HasColumnName("mfcr2_immediate_accept")
                    .HasColumnType("varchar(3)")
                    .HasDefaultValueSql("'no'");

                entity.Property(e => e.Mfcr2Logdir)
                    .HasColumnName("mfcr2_logdir")
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.Mfcr2Logging)
                    .HasColumnName("mfcr2_logging")
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.Mfcr2MaxAni)
                    .HasColumnName("mfcr2_max_ani")
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("'10'");

                entity.Property(e => e.Mfcr2MaxDnis)
                    .HasColumnName("mfcr2_max_dnis")
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("'4'");

                entity.Property(e => e.Mfcr2MeteringPulseTimeout)
                    .HasColumnName("mfcr2_metering_pulse_timeout")
                    .HasColumnType("decimal(10,0)");

                entity.Property(e => e.Mfcr2MfbackPulseTimeout)
                    .HasColumnName("mfcr2_mfback_pulse_timeout")
                    .HasColumnType("decimal(10,0)");

                entity.Property(e => e.Mfcr2MfbackTimeout)
                    .HasColumnName("mfcr2_mfback_timeout")
                    .HasColumnType("decimal(10,0)");

                entity.Property(e => e.Mfcr2SkipCatefory)
                    .IsRequired()
                    .HasColumnName("mfcr2_skip_catefory")
                    .HasColumnType("varchar(3)")
                    .HasDefaultValueSql("'no'");

                entity.Property(e => e.Mfcr2SkipCategory)
                    .IsRequired()
                    .HasColumnName("mfcr2_skip_category")
                    .HasColumnType("varchar(3)")
                    .HasDefaultValueSql("'no'");

                entity.Property(e => e.Mfcr2Variant)
                    .IsRequired()
                    .HasColumnName("mfcr2_variant")
                    .HasColumnType("varchar(3)")
                    .HasDefaultValueSql("'ITU'");

                entity.Property(e => e.MinCh)
                    .HasColumnName("min_ch")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasColumnType("varchar(25)");

                entity.Property(e => e.Pridialplan)
                    .HasColumnName("pridialplan")
                    .HasColumnType("varchar(25)");

                entity.Property(e => e.Priexclusive)
                    .IsRequired()
                    .HasColumnName("priexclusive")
                    .HasColumnType("varchar(3)");

                entity.Property(e => e.Prilocaldialplan)
                    .HasColumnName("prilocaldialplan")
                    .HasColumnType("varchar(25)");

                entity.Property(e => e.ReservedCh)
                    .HasColumnName("reserved_ch")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Rxgain)
                    .IsRequired()
                    .HasColumnName("rxgain")
                    .HasColumnType("varchar(10)")
                    .HasDefaultValueSql("'0.0'");

                entity.Property(e => e.Signalling)
                    .HasColumnName("signalling")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.Span)
                    .HasColumnName("span")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Spantype)
                    .HasColumnName("spantype")
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.Switchtype)
                    .HasColumnName("switchtype")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.Syncsrc)
                    .HasColumnName("syncsrc")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Timing)
                    .HasColumnName("timing")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Totchans)
                    .HasColumnName("totchans")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Txgain)
                    .IsRequired()
                    .HasColumnName("txgain")
                    .HasColumnType("varchar(10)")
                    .HasDefaultValueSql("'0.0'");

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasColumnType("varchar(25)");
            });

            modelBuilder.Entity<Daynight>(entity =>
            {
                entity.HasKey(e => new { e.Ext, e.Dmode, e.Dest });

                entity.ToTable("daynight");

                entity.Property(e => e.Ext)
                    .HasColumnName("ext")
                    .HasColumnType("varchar(10)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Dmode)
                    .HasColumnName("dmode")
                    .HasColumnType("varchar(40)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Dest)
                    .HasColumnName("dest")
                    .HasColumnType("varchar(190)")
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<DigiumaddoninstallerAddons>(entity =>
            {
                entity.ToTable("digiumaddoninstaller_addons");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("varchar(25)");

                entity.Property(e => e.CategoryIndex).HasColumnName("category_index");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasColumnType("text");

                entity.Property(e => e.Documentation)
                    .IsRequired()
                    .HasColumnName("documentation")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.IsInstalled)
                    .HasColumnName("is_installed")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.IsRegistered)
                    .HasColumnName("is_registered")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.IsUptodate)
                    .HasColumnName("is_uptodate")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Link)
                    .IsRequired()
                    .HasColumnName("link")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ProductIndex).HasColumnName("product_index");

                entity.Property(e => e.RegisterLimit)
                    .HasColumnName("register_limit")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("'not_installed'");

                entity.Property(e => e.SupportedVersion)
                    .HasColumnName("supported_version")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("'0.1'");
            });

            modelBuilder.Entity<DigiumaddoninstallerAddonsDownloads>(entity =>
            {
                entity.ToTable("digiumaddoninstaller_addons_downloads");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AddonId)
                    .HasColumnName("addon_id")
                    .HasColumnType("varchar(25)");

                entity.Property(e => e.DownloadId)
                    .HasColumnName("download_id")
                    .HasColumnType("varchar(25)");
            });

            modelBuilder.Entity<DigiumaddoninstallerDownloads>(entity =>
            {
                entity.ToTable("digiumaddoninstaller_downloads");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("varchar(25)");

                entity.Property(e => e.AvailableVersion)
                    .IsRequired()
                    .HasColumnName("available_version")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.InstalledVersion)
                    .IsRequired()
                    .HasColumnName("installed_version")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Package)
                    .IsRequired()
                    .HasColumnName("package")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("'{ast}-{name}'");

                entity.Property(e => e.Path)
                    .IsRequired()
                    .HasColumnName("path")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Tarball)
                    .IsRequired()
                    .HasColumnName("tarball")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("'{name}-{astver}_{version}-{arch}.tar.gz'");
            });

            modelBuilder.Entity<DigiumaddoninstallerDownloadsAstVersions>(entity =>
            {
                entity.ToTable("digiumaddoninstaller_downloads_ast_versions");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AstVersion)
                    .IsRequired()
                    .HasColumnName("ast_version")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.DownloadId)
                    .IsRequired()
                    .HasColumnName("download_id")
                    .HasColumnType("varchar(25)");
            });

            modelBuilder.Entity<DigiumaddoninstallerDownloadsBits>(entity =>
            {
                entity.ToTable("digiumaddoninstaller_downloads_bits");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Bit)
                    .HasColumnName("bit")
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.DownloadId)
                    .IsRequired()
                    .HasColumnName("download_id")
                    .HasColumnType("varchar(25)");
            });

            modelBuilder.Entity<DigiumaddoninstallerRegisters>(entity =>
            {
                entity.ToTable("digiumaddoninstaller_registers");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AddonId)
                    .IsRequired()
                    .HasColumnName("addon_id")
                    .HasColumnType("varchar(25)");

                entity.Property(e => e.Data)
                    .IsRequired()
                    .HasColumnName("data")
                    .HasColumnType("text");

                entity.Property(e => e.Filename)
                    .IsRequired()
                    .HasColumnName("filename")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.Path)
                    .IsRequired()
                    .HasColumnName("path")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.TimeRegistered)
                    .HasColumnName("time_registered")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("'CURRENT_TIMESTAMP'");
            });

            modelBuilder.Entity<DigiumaddoninstallerSystem>(entity =>
            {
                entity.ToTable("digiumaddoninstaller_system");

                entity.HasIndex(e => e.Variable)
                    .HasName("variable")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasColumnName("value")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Variable)
                    .IsRequired()
                    .HasColumnName("variable")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<DigiumPhonesAlerts>(entity =>
            {
                entity.ToTable("digium_phones_alerts");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Alertinfo)
                    .HasColumnName("alertinfo")
                    .HasColumnType("varchar(30)");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasColumnType("varchar(30)");

                entity.Property(e => e.Ringtone)
                    .HasColumnName("ringtone")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasColumnType("varchar(30)");
            });

            modelBuilder.Entity<DigiumPhonesCustomapps>(entity =>
            {
                entity.ToTable("digium_phones_customapps");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasColumnType("varchar(30)");
            });

            modelBuilder.Entity<DigiumPhonesCustomappSettings>(entity =>
            {
                entity.HasKey(e => new { e.Customappid, e.Keyword });

                entity.ToTable("digium_phones_customapp_settings");

                entity.Property(e => e.Customappid)
                    .HasColumnName("customappid")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Keyword)
                    .HasColumnName("keyword")
                    .HasColumnType("varchar(30)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Val)
                    .HasColumnName("val")
                    .HasColumnType("varchar(255)");
            });

            modelBuilder.Entity<DigiumPhonesDeviceAlerts>(entity =>
            {
                entity.HasKey(e => new { e.Deviceid, e.Alertid });

                entity.ToTable("digium_phones_device_alerts");

                entity.Property(e => e.Deviceid)
                    .HasColumnName("deviceid")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Alertid)
                    .HasColumnName("alertid")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<DigiumPhonesDeviceCustomapps>(entity =>
            {
                entity.HasKey(e => new { e.Deviceid, e.Customappid });

                entity.ToTable("digium_phones_device_customapps");

                entity.Property(e => e.Deviceid)
                    .HasColumnName("deviceid")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Customappid)
                    .HasColumnName("customappid")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<DigiumPhonesDeviceExternallines>(entity =>
            {
                entity.HasKey(e => new { e.Deviceid, e.Externallineid });

                entity.ToTable("digium_phones_device_externallines");

                entity.Property(e => e.Deviceid)
                    .HasColumnName("deviceid")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Externallineid)
                    .HasColumnName("externallineid")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<DigiumPhonesDeviceLogos>(entity =>
            {
                entity.HasKey(e => new { e.Deviceid, e.Logoid });

                entity.ToTable("digium_phones_device_logos");

                entity.Property(e => e.Deviceid)
                    .HasColumnName("deviceid")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Logoid)
                    .HasColumnName("logoid")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<DigiumPhonesDeviceMcpages>(entity =>
            {
                entity.HasKey(e => new { e.Deviceid, e.Mcpageid });

                entity.ToTable("digium_phones_device_mcpages");

                entity.Property(e => e.Deviceid)
                    .HasColumnName("deviceid")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Mcpageid)
                    .HasColumnName("mcpageid")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<DigiumPhonesDeviceNetworks>(entity =>
            {
                entity.HasKey(e => new { e.Deviceid, e.Networkid });

                entity.ToTable("digium_phones_device_networks");

                entity.Property(e => e.Deviceid)
                    .HasColumnName("deviceid")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Networkid)
                    .HasColumnName("networkid")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<DigiumPhonesDeviceParkapps>(entity =>
            {
                entity.HasKey(e => new { e.Deviceid, e.Category });

                entity.ToTable("digium_phones_device_parkapps");

                entity.Property(e => e.Deviceid)
                    .HasColumnName("deviceid")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Category)
                    .HasColumnName("category")
                    .HasColumnType("varchar(45)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<DigiumPhonesDevicePhonebooks>(entity =>
            {
                entity.HasKey(e => new { e.Deviceid, e.Phonebookid });

                entity.ToTable("digium_phones_device_phonebooks");

                entity.Property(e => e.Deviceid)
                    .HasColumnName("deviceid")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Phonebookid)
                    .HasColumnName("phonebookid")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<DigiumPhonesDeviceRingtones>(entity =>
            {
                entity.HasKey(e => new { e.Deviceid, e.Ringtoneid });

                entity.ToTable("digium_phones_device_ringtones");

                entity.Property(e => e.Deviceid)
                    .HasColumnName("deviceid")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Ringtoneid)
                    .HasColumnName("ringtoneid")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<DigiumPhonesDevices>(entity =>
            {
                entity.ToTable("digium_phones_devices");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasColumnType("varchar(30)");
            });

            modelBuilder.Entity<DigiumPhonesDeviceSettings>(entity =>
            {
                entity.HasKey(e => new { e.Deviceid, e.Keyword });

                entity.ToTable("digium_phones_device_settings");

                entity.Property(e => e.Deviceid)
                    .HasColumnName("deviceid")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Keyword)
                    .HasColumnName("keyword")
                    .HasColumnType("varchar(30)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Val)
                    .HasColumnName("val")
                    .HasColumnType("varchar(255)");
            });

            modelBuilder.Entity<DigiumPhonesDeviceStatuses>(entity =>
            {
                entity.HasKey(e => new { e.Deviceid, e.Statusid });

                entity.ToTable("digium_phones_device_statuses");

                entity.Property(e => e.Deviceid)
                    .HasColumnName("deviceid")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Statusid)
                    .HasColumnName("statusid")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<DigiumPhonesExtensionSettings>(entity =>
            {
                entity.HasKey(e => new { e.Extension, e.Keyword });

                entity.ToTable("digium_phones_extension_settings");

                entity.Property(e => e.Extension)
                    .HasColumnName("extension")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Keyword)
                    .HasColumnName("keyword")
                    .HasColumnType("varchar(30)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Val)
                    .HasColumnName("val")
                    .HasColumnType("varchar(255)");
            });

            modelBuilder.Entity<DigiumPhonesExternallines>(entity =>
            {
                entity.ToTable("digium_phones_externallines");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasColumnType("varchar(30)");
            });

            modelBuilder.Entity<DigiumPhonesExternallineSettings>(entity =>
            {
                entity.HasKey(e => new { e.Externallineid, e.Keyword });

                entity.ToTable("digium_phones_externalline_settings");

                entity.Property(e => e.Externallineid)
                    .HasColumnName("externallineid")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Keyword)
                    .HasColumnName("keyword")
                    .HasColumnType("varchar(30)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Val)
                    .HasColumnName("val")
                    .HasColumnType("varchar(255)");
            });

            modelBuilder.Entity<DigiumPhonesFirmware>(entity =>
            {
                entity.HasKey(e => e.UniqueId);

                entity.ToTable("digium_phones_firmware");

                entity.Property(e => e.UniqueId)
                    .HasColumnName("unique_id")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.FileName)
                    .IsRequired()
                    .HasColumnName("file_name")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.PackageId)
                    .IsRequired()
                    .HasColumnName("package_id")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.PhoneModel)
                    .IsRequired()
                    .HasColumnName("phone_model")
                    .HasColumnType("varchar(30)");
            });

            modelBuilder.Entity<DigiumPhonesFirmwarePackages>(entity =>
            {
                entity.HasKey(e => e.UniqueId);

                entity.ToTable("digium_phones_firmware_packages");

                entity.Property(e => e.UniqueId)
                    .HasColumnName("unique_id")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.FilePath)
                    .IsRequired()
                    .HasColumnName("file_path")
                    .HasColumnType("varchar(512)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.Version)
                    .IsRequired()
                    .HasColumnName("version")
                    .HasColumnType("varchar(30)");
            });

            modelBuilder.Entity<DigiumPhonesGeneral>(entity =>
            {
                entity.HasKey(e => e.Keyword);

                entity.ToTable("digium_phones_general");

                entity.Property(e => e.Keyword)
                    .HasColumnName("keyword")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.DefaultVal)
                    .HasColumnName("default_val")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.Val)
                    .HasColumnName("val")
                    .HasColumnType("varchar(255)");
            });

            modelBuilder.Entity<DigiumPhonesLines>(entity =>
            {
                entity.HasKey(e => new { e.Deviceid, e.Extension });

                entity.ToTable("digium_phones_lines");

                entity.Property(e => e.Deviceid)
                    .HasColumnName("deviceid")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Extension)
                    .HasColumnName("extension")
                    .HasColumnType("varchar(45)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<DigiumPhonesLogos>(entity =>
            {
                entity.ToTable("digium_phones_logos");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Model)
                    .HasColumnName("model")
                    .HasColumnType("varchar(30)");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasColumnType("varchar(30)");
            });

            modelBuilder.Entity<DigiumPhonesMcpages>(entity =>
            {
                entity.ToTable("digium_phones_mcpages");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasColumnType("varchar(30)");
            });

            modelBuilder.Entity<DigiumPhonesMcpageSettings>(entity =>
            {
                entity.HasKey(e => new { e.Mcpageid, e.Keyword });

                entity.ToTable("digium_phones_mcpage_settings");

                entity.Property(e => e.Mcpageid)
                    .HasColumnName("mcpageid")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Keyword)
                    .HasColumnName("keyword")
                    .HasColumnType("varchar(30)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Val)
                    .HasColumnName("val")
                    .HasColumnType("varchar(255)");
            });

            modelBuilder.Entity<DigiumPhonesNetworks>(entity =>
            {
                entity.ToTable("digium_phones_networks");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasColumnType("varchar(30)");
            });

            modelBuilder.Entity<DigiumPhonesNetworkSettings>(entity =>
            {
                entity.HasKey(e => new { e.Networkid, e.Keyword });

                entity.ToTable("digium_phones_network_settings");

                entity.Property(e => e.Networkid)
                    .HasColumnName("networkid")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Keyword)
                    .HasColumnName("keyword")
                    .HasColumnType("varchar(30)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Val)
                    .HasColumnName("val")
                    .HasColumnType("varchar(255)");
            });

            modelBuilder.Entity<DigiumPhonesPhonebookEntries>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.Phonebookid });

                entity.ToTable("digium_phones_phonebook_entries");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Phonebookid)
                    .HasColumnName("phonebookid")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Extension)
                    .HasColumnName("extension")
                    .HasColumnType("varchar(45)");
            });

            modelBuilder.Entity<DigiumPhonesPhonebookEntrySettings>(entity =>
            {
                entity.HasKey(e => new { e.Phonebookid, e.Phonebookentryid, e.Keyword });

                entity.ToTable("digium_phones_phonebook_entry_settings");

                entity.Property(e => e.Phonebookid)
                    .HasColumnName("phonebookid")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Phonebookentryid)
                    .HasColumnName("phonebookentryid")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Keyword)
                    .HasColumnName("keyword")
                    .HasColumnType("varchar(30)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Val)
                    .HasColumnName("val")
                    .HasColumnType("varchar(255)");
            });

            modelBuilder.Entity<DigiumPhonesPhonebooks>(entity =>
            {
                entity.ToTable("digium_phones_phonebooks");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasColumnType("varchar(30)");
            });

            modelBuilder.Entity<DigiumPhonesPnacs>(entity =>
            {
                entity.ToTable("digium_phones_pnacs");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasColumnType("varchar(30)");
            });

            modelBuilder.Entity<DigiumPhonesPnacSettings>(entity =>
            {
                entity.HasKey(e => new { e.Pnacid, e.Keyword });

                entity.ToTable("digium_phones_pnac_settings");

                entity.Property(e => e.Pnacid)
                    .HasColumnName("pnacid")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Keyword)
                    .HasColumnName("keyword")
                    .HasColumnType("varchar(30)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Val)
                    .HasColumnName("val")
                    .HasColumnType("varchar(255)");
            });

            modelBuilder.Entity<DigiumPhonesQueues>(entity =>
            {
                entity.HasKey(e => new { e.Queueid, e.Deviceid, e.Permission });

                entity.ToTable("digium_phones_queues");

                entity.Property(e => e.Queueid)
                    .HasColumnName("queueid")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Deviceid)
                    .HasColumnName("deviceid")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Permission)
                    .HasColumnName("permission")
                    .HasColumnType("varchar(8)")
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<DigiumPhonesRingtones>(entity =>
            {
                entity.ToTable("digium_phones_ringtones");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Builtin)
                    .HasColumnName("builtin")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Filename)
                    .HasColumnName("filename")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasColumnType("varchar(30)");
            });

            modelBuilder.Entity<DigiumPhonesStatusEntries>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.Statusid });

                entity.ToTable("digium_phones_status_entries");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Statusid)
                    .HasColumnName("statusid")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Text)
                    .HasColumnName("text")
                    .HasColumnType("varchar(255)");
            });

            modelBuilder.Entity<DigiumPhonesStatuses>(entity =>
            {
                entity.ToTable("digium_phones_statuses");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasColumnType("varchar(30)");
            });

            modelBuilder.Entity<DigiumPhonesStatusSettings>(entity =>
            {
                entity.HasKey(e => new { e.Statusid, e.Keyword });

                entity.ToTable("digium_phones_status_settings");

                entity.Property(e => e.Statusid)
                    .HasColumnName("statusid")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Keyword)
                    .HasColumnName("keyword")
                    .HasColumnType("varchar(30)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Val)
                    .HasColumnName("val")
                    .HasColumnType("varchar(255)");
            });

            modelBuilder.Entity<DigiumPhonesVoicemailTranslations>(entity =>
            {
                entity.HasKey(e => new { e.Locale, e.Keyword });

                entity.ToTable("digium_phones_voicemail_translations");

                entity.Property(e => e.Locale)
                    .HasColumnName("locale")
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.Keyword)
                    .HasColumnName("keyword")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.Val)
                    .IsRequired()
                    .HasColumnName("val")
                    .HasColumnType("varchar(255)");
            });

            modelBuilder.Entity<DirectoryDetails>(entity =>
            {
                entity.ToTable("directory_details");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AlertInfo)
                    .HasColumnName("alert_info")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.Announcement)
                    .HasColumnName("announcement")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CallidPrefix)
                    .HasColumnName("callid_prefix")
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasColumnType("varchar(150)");

                entity.Property(e => e.Dirname)
                    .HasColumnName("dirname")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.InvalidDestination)
                    .HasColumnName("invalid_destination")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.InvalidRecording)
                    .HasColumnName("invalid_recording")
                    .HasColumnType("int(11)");

                entity.Property(e => e.RepeatLoops)
                    .HasColumnName("repeat_loops")
                    .HasColumnType("varchar(3)");

                entity.Property(e => e.RepeatRecording)
                    .HasColumnName("repeat_recording")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Retivr)
                    .HasColumnName("retivr")
                    .HasColumnType("varchar(5)");

                entity.Property(e => e.Rvolume)
                    .IsRequired()
                    .HasColumnName("rvolume")
                    .HasColumnType("varchar(2)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.SayExtension)
                    .HasColumnName("say_extension")
                    .HasColumnType("varchar(5)");
            });

            modelBuilder.Entity<Disa>(entity =>
            {
                entity.ToTable("disa");

                entity.Property(e => e.DisaId)
                    .HasColumnName("disa_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Cid)
                    .HasColumnName("cid")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.Context)
                    .HasColumnName("context")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.Digittimeout)
                    .HasColumnName("digittimeout")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Displayname)
                    .HasColumnName("displayname")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.Hangup)
                    .HasColumnName("hangup")
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.Keepcid)
                    .HasColumnName("keepcid")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Needconf)
                    .HasColumnName("needconf")
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.Pin)
                    .HasColumnName("pin")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.Resptimeout)
                    .HasColumnName("resptimeout")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<EndpointBasefiles>(entity =>
            {
                entity.ToTable("endpoint_basefiles");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Attrib)
                    .HasColumnName("attrib")
                    .HasColumnType("varchar(60)");

                entity.Property(e => e.Brand)
                    .HasColumnName("brand")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Define)
                    .HasColumnName("define")
                    .HasColumnType("varchar(80)");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasColumnType("varchar(160)");

                entity.Property(e => e.Edited)
                    .HasColumnName("edited")
                    .HasColumnType("varchar(1)");

                entity.Property(e => e.File)
                    .HasColumnName("file")
                    .HasColumnType("varchar(40)");

                entity.Property(e => e.Model)
                    .HasColumnName("model")
                    .HasColumnType("varchar(512)");

                entity.Property(e => e.Oid)
                    .HasColumnName("OID")
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.Param)
                    .HasColumnName("param")
                    .HasColumnType("varchar(120)");

                entity.Property(e => e.Template)
                    .HasColumnName("template")
                    .HasColumnType("varchar(45)");

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Value)
                    .HasColumnName("value")
                    .HasColumnType("varchar(254)");
            });

            modelBuilder.Entity<EndpointButtons>(entity =>
            {
                entity.ToTable("endpoint_buttons");

                entity.HasIndex(e => e.Id)
                    .HasName("id")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.Brand)
                    .IsRequired()
                    .HasColumnName("brand")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Daylight)
                    .HasColumnName("daylight")
                    .HasColumnType("varchar(2)");

                entity.Property(e => e.Key)
                    .IsRequired()
                    .HasColumnName("key")
                    .HasColumnType("varchar(60)");

                entity.Property(e => e.TemplateName)
                    .IsRequired()
                    .HasColumnName("template_name")
                    .HasColumnType("varchar(45)");

                entity.Property(e => e.Value)
                    .HasColumnName("value")
                    .HasColumnType("varchar(120)");
            });

            modelBuilder.Entity<EndpointExtButtons>(entity =>
            {
                entity.ToTable("endpoint_ext_buttons");

                entity.HasIndex(e => e.Id)
                    .HasName("id")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.Brand)
                    .IsRequired()
                    .HasColumnName("brand")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Ext)
                    .IsRequired()
                    .HasColumnName("ext")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Key)
                    .IsRequired()
                    .HasColumnName("key")
                    .HasColumnType("varchar(60)");

                entity.Property(e => e.TemplateName)
                    .IsRequired()
                    .HasColumnName("template_name")
                    .HasColumnType("varchar(45)");

                entity.Property(e => e.Value)
                    .HasColumnName("value")
                    .HasColumnType("varchar(120)");
            });

            modelBuilder.Entity<EndpointExtensions>(entity =>
            {
                entity.HasKey(e => e.Ext);

                entity.ToTable("endpoint_extensions");

                entity.HasIndex(e => e.Ext)
                    .HasName("ext")
                    .IsUnique();

                entity.Property(e => e.Ext)
                    .HasColumnName("ext")
                    .HasColumnType("varchar(25)");

                entity.Property(e => e.Accessory)
                    .HasColumnName("accessory")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.Account)
                    .HasColumnName("account")
                    .HasColumnType("varchar(12)");

                entity.Property(e => e.Basestation)
                    .HasColumnName("basestation")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.Blf)
                    .HasColumnName("blf")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.BlfLabel)
                    .HasColumnName("blf_label")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Brand)
                    .HasColumnName("brand")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Country)
                    .HasColumnName("country")
                    .HasColumnType("varchar(3)");

                entity.Property(e => e.Exp0)
                    .HasColumnName("exp0")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Exp1)
                    .HasColumnName("exp1")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Exp2)
                    .HasColumnName("exp2")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Exp3)
                    .HasColumnName("exp3")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Exp4)
                    .HasColumnName("exp4")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Exp5)
                    .HasColumnName("exp5")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Mac)
                    .HasColumnName("mac")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Model)
                    .HasColumnName("model")
                    .HasColumnType("varchar(25)");

                entity.Property(e => e.Multicell)
                    .HasColumnName("multicell")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.Rebuild)
                    .HasColumnName("rebuild")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Repeater1)
                    .HasColumnName("repeater1")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.Repeater2)
                    .HasColumnName("repeater2")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Repeater3)
                    .HasColumnName("repeater3")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Template)
                    .HasColumnName("template")
                    .HasColumnType("varchar(45)");

                entity.Property(e => e.Vpn)
                    .HasColumnName("vpn")
                    .HasColumnType("bigint(20)");
            });

            modelBuilder.Entity<EndpointTemplates>(entity =>
            {
                entity.ToTable("endpoint_templates");

                entity.HasIndex(e => e.Id)
                    .HasName("id")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.Acr)
                    .HasColumnName("acr")
                    .HasColumnType("varchar(2)");

                entity.Property(e => e.ActivecallStatus)
                    .HasColumnName("activecallStatus")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Answer)
                    .HasColumnName("answer")
                    .HasColumnType("varchar(1)");

                entity.Property(e => e.Background)
                    .HasColumnName("background")
                    .HasColumnType("varchar(256)");

                entity.Property(e => e.BacklightActive)
                    .HasColumnName("backlightActive")
                    .HasColumnType("varchar(4)");

                entity.Property(e => e.BacklightInActive)
                    .HasColumnName("backlightInActive")
                    .HasColumnType("varchar(4)");

                entity.Property(e => e.BacklightTimeout)
                    .HasColumnName("backlightTimeout")
                    .HasColumnType("varchar(4)");

                entity.Property(e => e.BackupDest)
                    .HasColumnName("backupDest")
                    .HasColumnType("varchar(40)");

                entity.Property(e => e.BackupOutboundProxy)
                    .HasColumnName("backupOutboundProxy")
                    .HasColumnType("varchar(40)");

                entity.Property(e => e.BackupOutboundProxyPort)
                    .HasColumnName("backupOutboundProxyPort")
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.BackupPort)
                    .HasColumnName("backupPort")
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.Barge)
                    .HasColumnName("barge")
                    .HasColumnType("varchar(1)");

                entity.Property(e => e.Brand)
                    .HasColumnName("brand")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.BrowserNote)
                    .HasColumnName("browserNote")
                    .HasColumnType("varchar(2)");

                entity.Property(e => e.Callwaiting)
                    .HasColumnName("callwaiting")
                    .HasColumnType("varchar(2)");

                entity.Property(e => e.ConfCallRelease)
                    .HasColumnName("confCallRelease")
                    .HasColumnType("varchar(2)");

                entity.Property(e => e.ContactPhoto)
                    .HasColumnName("contactPhoto")
                    .HasColumnType("varchar(2)");

                entity.Property(e => e.Country)
                    .HasColumnName("country")
                    .HasColumnType("varchar(3)");

                entity.Property(e => e.DVlan)
                    .HasColumnName("dVlan")
                    .HasColumnType("varchar(5)");

                entity.Property(e => e.DateFormat)
                    .HasColumnName("dateFormat")
                    .HasColumnType("varchar(2)");

                entity.Property(e => e.Daylight)
                    .HasColumnName("daylight")
                    .HasColumnType("varchar(2)");

                entity.Property(e => e.Default)
                    .HasColumnName("default")
                    .HasColumnType("varchar(2)");

                entity.Property(e => e.Destination)
                    .HasColumnName("destination")
                    .HasColumnType("varchar(40)");

                entity.Property(e => e.DhcpVlan)
                    .HasColumnName("dhcpVlan")
                    .HasColumnType("varchar(2)");

                entity.Property(e => e.DialFirstDigit)
                    .HasColumnName("dialFirstDigit")
                    .HasColumnType("varchar(2)");

                entity.Property(e => e.DialNow)
                    .HasColumnName("dialNow")
                    .HasColumnType("varchar(4)");

                entity.Property(e => e.Dialpattern)
                    .HasColumnName("dialpattern")
                    .HasColumnType("varchar(512)");

                entity.Property(e => e.DstEd)
                    .HasColumnName("dstED")
                    .HasColumnType("varchar(2)");

                entity.Property(e => e.DstEm)
                    .HasColumnName("dstEM")
                    .HasColumnType("varchar(2)");

                entity.Property(e => e.DstEt)
                    .HasColumnName("dstET")
                    .HasColumnType("varchar(2)");

                entity.Property(e => e.DstEw)
                    .HasColumnName("dstEW")
                    .HasColumnType("varchar(2)");

                entity.Property(e => e.DstSd)
                    .HasColumnName("dstSD")
                    .HasColumnType("varchar(2)");

                entity.Property(e => e.DstSm)
                    .HasColumnName("dstSM")
                    .HasColumnType("varchar(2)");

                entity.Property(e => e.DstSt)
                    .HasColumnName("dstST")
                    .HasColumnType("varchar(2)");

                entity.Property(e => e.DstSw)
                    .HasColumnName("dstSW")
                    .HasColumnType("varchar(2)");

                entity.Property(e => e.Echo)
                    .HasColumnName("echo")
                    .HasColumnType("varchar(1)");

                entity.Property(e => e.EntryTimeout)
                    .HasColumnName("entryTimeout")
                    .HasColumnType("varchar(2)");

                entity.Property(e => e.Ext)
                    .HasColumnName("ext")
                    .HasColumnType("varchar(80)");

                entity.Property(e => e.ExternalDefault)
                    .HasColumnName("externalDefault")
                    .HasColumnType("varchar(3)");

                entity.Property(e => e.Extra)
                    .HasColumnName("extra")
                    .HasColumnType("varchar(400)");

                entity.Property(e => e.Features)
                    .HasColumnName("features")
                    .HasColumnType("varchar(1024)");

                entity.Property(e => e.Firmware)
                    .HasColumnName("firmware")
                    .HasColumnType("varchar(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Focus)
                    .HasColumnName("focus")
                    .HasColumnType("varchar(1)");

                entity.Property(e => e.FontSize)
                    .HasColumnName("fontSize")
                    .HasColumnType("varchar(2)");

                entity.Property(e => e.Ftppass)
                    .HasColumnName("ftppass")
                    .HasColumnType("varchar(40)");

                entity.Property(e => e.Ftpserver)
                    .HasColumnName("ftpserver")
                    .HasColumnType("varchar(250)");

                entity.Property(e => e.Ftpuser)
                    .HasColumnName("ftpuser")
                    .HasColumnType("varchar(40)");

                entity.Property(e => e.GuiOverride)
                    .HasColumnName("guiOverride")
                    .HasColumnType("varchar(2)");

                entity.Property(e => e.Headset)
                    .HasColumnName("headset")
                    .HasColumnType("varchar(4)");

                entity.Property(e => e.HoldTone)
                    .HasColumnName("holdTone")
                    .HasColumnType("varchar(2)");

                entity.Property(e => e.HoldToneDelay)
                    .HasColumnName("holdToneDelay")
                    .HasColumnType("varchar(2)");

                entity.Property(e => e.Hotline)
                    .HasColumnName("hotline")
                    .HasColumnType("varchar(2)");

                entity.Property(e => e.HotlineDest)
                    .HasColumnName("hotlineDest")
                    .HasColumnType("varchar(254)");

                entity.Property(e => e.InternalDefault)
                    .HasColumnName("internalDefault")
                    .HasColumnType("varchar(3)");

                entity.Property(e => e.KeypressTone)
                    .HasColumnName("keypressTone")
                    .HasColumnType("varchar(2)");

                entity.Property(e => e.LabelScroll)
                    .HasColumnName("labelScroll")
                    .HasColumnType("varchar(4)");

                entity.Property(e => e.Language)
                    .HasColumnName("language")
                    .HasColumnType("varchar(2)");

                entity.Property(e => e.LcdLanguage)
                    .HasColumnName("lcdLanguage")
                    .HasColumnType("varchar(2)");

                entity.Property(e => e.LdapBase)
                    .HasColumnName("ldapBase")
                    .HasColumnType("varchar(80)");

                entity.Property(e => e.LdapDisplayName)
                    .HasColumnName("ldapDisplayName")
                    .HasColumnType("varchar(60)");

                entity.Property(e => e.LdapLookupCall)
                    .HasColumnName("ldapLookupCall")
                    .HasColumnType("varchar(2)");

                entity.Property(e => e.LdapMaxHits)
                    .HasColumnName("ldapMaxHits")
                    .HasColumnType("varchar(4)");

                entity.Property(e => e.LdapNameAttributes)
                    .HasColumnName("ldapNameAttributes")
                    .HasColumnType("varchar(60)");

                entity.Property(e => e.LdapNameFilter)
                    .HasColumnName("ldapNameFilter")
                    .HasColumnType("varchar(60)");

                entity.Property(e => e.LdapNumberAttributes)
                    .HasColumnName("ldapNumberAttributes")
                    .HasColumnType("varchar(60)");

                entity.Property(e => e.LdapNumberFilter)
                    .HasColumnName("ldapNumberFilter")
                    .HasColumnType("varchar(60)");

                entity.Property(e => e.LdapPassword)
                    .HasColumnName("ldapPassword")
                    .HasColumnType("varchar(60)");

                entity.Property(e => e.LdapPort)
                    .HasColumnName("ldapPort")
                    .HasColumnType("varchar(60)");

                entity.Property(e => e.LdapSearchDelay)
                    .HasColumnName("ldapSearchDelay")
                    .HasColumnType("varchar(4)");

                entity.Property(e => e.LdapServerAddress)
                    .HasColumnName("ldapServerAddress")
                    .HasColumnType("varchar(60)");

                entity.Property(e => e.LdapSort)
                    .HasColumnName("ldapSort")
                    .HasColumnType("varchar(2)");

                entity.Property(e => e.LdapUsername)
                    .HasColumnName("ldapUsername")
                    .HasColumnType("varchar(128)");

                entity.Property(e => e.LineLabel)
                    .HasColumnName("lineLabel")
                    .HasColumnType("varchar(2)");

                entity.Property(e => e.Lldp)
                    .HasColumnName("lldp")
                    .HasColumnType("varchar(2)");

                entity.Property(e => e.LldpPacket)
                    .HasColumnName("lldpPacket")
                    .HasColumnType("varchar(5)");

                entity.Property(e => e.LldpProtocol)
                    .HasColumnName("lldpProtocol")
                    .HasColumnType("varchar(2)");

                entity.Property(e => e.Logoled)
                    .HasColumnName("logoled")
                    .HasColumnType("varchar(2)");

                entity.Property(e => e.LongPressIdleState)
                    .HasColumnName("longPressIdleState")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.LongPressInUseState)
                    .HasColumnName("longPressInUseState")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.LongPressRingState)
                    .HasColumnName("longPressRingState")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Menukey)
                    .HasColumnName("menukey")
                    .HasColumnType("varchar(2)");

                entity.Property(e => e.Menupin)
                    .HasColumnName("menupin")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.MisscallsStatus)
                    .HasColumnName("misscallsStatus")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Missed)
                    .HasColumnName("missed")
                    .HasColumnType("varchar(1)");

                entity.Property(e => e.Models)
                    .HasColumnName("models")
                    .HasColumnType("varchar(200)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.MulticastAddress)
                    .HasColumnName("multicastAddress")
                    .HasColumnType("varchar(1024)");

                entity.Property(e => e.MulticastEnable)
                    .HasColumnName("multicastEnable")
                    .HasColumnType("varchar(2)");

                entity.Property(e => e.Mute)
                    .HasColumnName("mute")
                    .HasColumnType("varchar(1)");

                entity.Property(e => e.Offhook)
                    .HasColumnName("offhook")
                    .HasColumnType("varchar(1)");

                entity.Property(e => e.OutboundProxy)
                    .HasColumnName("outboundProxy")
                    .HasColumnType("varchar(40)");

                entity.Property(e => e.OutboundProxyPort)
                    .HasColumnName("outboundProxyPort")
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.Outgoing)
                    .HasColumnName("outgoing")
                    .HasColumnType("varchar(256)");

                entity.Property(e => e.PhoneApps)
                    .HasColumnName("phoneApps")
                    .HasColumnType("varchar(5)");

                entity.Property(e => e.PhoneLabel)
                    .HasColumnName("phoneLabel")
                    .HasColumnType("varchar(64)");

                entity.Property(e => e.PowerStatus)
                    .HasColumnName("powerStatus")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Protocol)
                    .HasColumnName("protocol")
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.RemoteDisconnect)
                    .HasColumnName("remoteDisconnect")
                    .HasColumnType("varchar(2)");

                entity.Property(e => e.RingingStatus)
                    .HasColumnName("ringingStatus")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.ShortPressIdleState)
                    .HasColumnName("shortPressIdleState")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.ShortPressInUseState)
                    .HasColumnName("shortPressInUseState")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.SsSchedule)
                    .HasColumnName("ssSchedule")
                    .HasColumnType("varchar(1024)");

                entity.Property(e => e.SsText)
                    .HasColumnName("ssText")
                    .HasColumnType("varchar(254)");

                entity.Property(e => e.Stutter)
                    .HasColumnName("stutter")
                    .HasColumnType("varchar(1)");

                entity.Property(e => e.TemplateName)
                    .HasColumnName("template_name")
                    .HasColumnType("varchar(45)");

                entity.Property(e => e.TimeFormat)
                    .HasColumnName("timeFormat")
                    .HasColumnType("varchar(2)");

                entity.Property(e => e.TimeServer)
                    .HasColumnName("time_server")
                    .HasColumnType("varchar(1)");

                entity.Property(e => e.TimeServer1)
                    .HasColumnName("time_server_1")
                    .HasColumnType("varchar(30)");

                entity.Property(e => e.TimeServer2)
                    .HasColumnName("time_server_2")
                    .HasColumnType("varchar(30)");

                entity.Property(e => e.TimeServer3)
                    .HasColumnName("time_server_3")
                    .HasColumnType("varchar(30)");

                entity.Property(e => e.Timeout)
                    .HasColumnName("timeout")
                    .HasColumnType("varchar(2)");

                entity.Property(e => e.Timezone)
                    .HasColumnName("timezone")
                    .HasColumnType("varchar(30)");

                entity.Property(e => e.Toneset)
                    .HasColumnName("toneset")
                    .HasColumnType("varchar(12)");

                entity.Property(e => e.VVlan)
                    .HasColumnName("vVlan")
                    .HasColumnType("varchar(5)");

                entity.Property(e => e.VVlanP)
                    .HasColumnName("vVlanP")
                    .HasColumnType("varchar(5)");

                entity.Property(e => e.VlanIdentity)
                    .HasColumnName("vlanIdentity")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.VlanMode)
                    .HasColumnName("vlanMode")
                    .HasColumnType("varchar(2)");

                entity.Property(e => e.VlanPass)
                    .HasColumnName("vlanPass")
                    .HasColumnType("varchar(64)");

                entity.Property(e => e.VoicemailTone)
                    .HasColumnName("voicemailTone")
                    .HasColumnType("varchar(2)");

                entity.Property(e => e.Voicemailkey)
                    .HasColumnName("voicemailkey")
                    .HasColumnType("varchar(2)");

                entity.Property(e => e.VoicemessageStatus)
                    .HasColumnName("voicemessageStatus")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Volume)
                    .HasColumnName("volume")
                    .HasColumnType("varchar(2)");

                entity.Property(e => e.WEnable1)
                    .HasColumnName("wEnable1")
                    .HasColumnType("varchar(2)");

                entity.Property(e => e.WWepbits1)
                    .HasColumnName("wWEPBits1")
                    .HasColumnType("varchar(5)");

                entity.Property(e => e.WWpapskkey1)
                    .HasColumnName("wWPAPSKKey1")
                    .HasColumnType("varchar(64)");

                entity.Property(e => e.WWpapskpass1)
                    .HasColumnName("wWPAPSKPass1")
                    .HasColumnType("varchar(64)");

                entity.Property(e => e.Wsecurity1)
                    .HasColumnName("wsecurity1")
                    .HasColumnType("varchar(2)");

                entity.Property(e => e.Wssid1)
                    .HasColumnName("wssid1")
                    .HasColumnType("varchar(64)");
            });

            modelBuilder.Entity<EndpointTimezones>(entity =>
            {
                entity.ToTable("endpoint_timezones");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Aastra)
                    .HasColumnName("aastra")
                    .HasColumnType("varchar(30)");

                entity.Property(e => e.And)
                    .HasColumnName("and")
                    .HasColumnType("varchar(35)");

                entity.Property(e => e.Cisco)
                    .HasColumnName("cisco")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.CiscoEnt)
                    .HasColumnName("ciscoEnt")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.CiscoFxs)
                    .HasColumnName("ciscoFxs")
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.Code)
                    .HasColumnName("code")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.Cortelco)
                    .HasColumnName("cortelco")
                    .HasColumnType("varchar(3)");

                entity.Property(e => e.Digium)
                    .HasColumnName("digium")
                    .HasColumnType("varchar(40)");

                entity.Property(e => e.Dp715)
                    .HasColumnName("dp715")
                    .HasColumnType("varchar(40)");

                entity.Property(e => e.Grandstream)
                    .HasColumnName("grandstream")
                    .HasColumnType("varchar(60)");

                entity.Property(e => e.Htek)
                    .HasColumnName("htek")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.Incom)
                    .HasColumnName("incom")
                    .HasColumnType("varchar(5)");

                entity.Property(e => e.Location)
                    .HasColumnName("location")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.Mbu)
                    .HasColumnName("mbu")
                    .HasColumnType("varchar(3)");

                entity.Property(e => e.Mocet)
                    .HasColumnName("mocet")
                    .HasColumnType("varchar(3)");

                entity.Property(e => e.Obihai)
                    .HasColumnName("obihai")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.Offset)
                    .HasColumnName("offset")
                    .HasColumnType("varchar(8)");

                entity.Property(e => e.Panasonic)
                    .HasColumnName("panasonic")
                    .HasColumnType("varchar(5)");

                entity.Property(e => e.Panasonic2)
                    .HasColumnName("panasonic2")
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.Phoenix)
                    .HasColumnName("phoenix")
                    .HasColumnType("varchar(60)");

                entity.Property(e => e.Snom)
                    .HasColumnName("snom")
                    .HasColumnType("varchar(3)");

                entity.Property(e => e.Snomv8)
                    .HasColumnName("snomv8")
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.Vtech)
                    .HasColumnName("vtech")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.Yealink)
                    .HasColumnName("yealink")
                    .HasColumnType("varchar(40)");
            });

            modelBuilder.Entity<Extensionroutes>(entity =>
            {
                entity.HasKey(e => new { e.Exten, e.RouteId });

                entity.ToTable("extensionroutes");

                entity.Property(e => e.Exten)
                    .HasColumnName("exten")
                    .HasColumnType("varchar(20)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.RouteId)
                    .HasColumnName("route_id")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<FaxproHookCore>(entity =>
            {
                entity.HasKey(e => new { e.Page, e.Id });

                entity.ToTable("faxpro_hook_core");

                entity.Property(e => e.Page)
                    .HasColumnName("page")
                    .HasColumnType("varchar(150)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("varchar(150)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<FaxStore>(entity =>
            {
                entity.HasKey(e => e.Faxid);

                entity.ToTable("fax_store");

                entity.Property(e => e.Faxid)
                    .HasColumnName("faxid")
                    .HasColumnType("varchar(25)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Callid)
                    .HasColumnName("callid")
                    .HasColumnType("varchar(75)");

                entity.Property(e => e.Channel)
                    .HasColumnName("channel")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasColumnType("varchar(12)");

                entity.Property(e => e.Dest)
                    .HasColumnName("dest")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Dir)
                    .HasColumnName("dir")
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.File)
                    .HasColumnName("file")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.Finished)
                    .HasColumnName("finished")
                    .HasColumnType("varchar(2)")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Header)
                    .HasColumnName("header")
                    .HasColumnType("varchar(80)");

                entity.Property(e => e.New)
                    .HasColumnName("new")
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.Pages)
                    .HasColumnName("pages")
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.Pid)
                    .HasColumnName("pid")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Stationid)
                    .HasColumnName("stationid")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.User)
                    .HasColumnName("user")
                    .HasColumnType("varchar(25)");
            });

            modelBuilder.Entity<Featurecodes>(entity =>
            {
                entity.HasKey(e => new { e.Modulename, e.Featurename });

                entity.ToTable("featurecodes");

                entity.HasIndex(e => e.Enabled)
                    .HasName("enabled");

                entity.Property(e => e.Modulename)
                    .HasColumnName("modulename")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Featurename)
                    .HasColumnName("featurename")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Customcode)
                    .HasColumnName("customcode")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Defaultcode)
                    .HasColumnName("defaultcode")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description")
                    .HasColumnType("varchar(200)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Enabled)
                    .HasColumnName("enabled")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Helptext)
                    .IsRequired()
                    .HasColumnName("helptext")
                    .HasColumnType("varchar(250)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Providedest)
                    .HasColumnName("providedest")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<Findmefollow>(entity =>
            {
                entity.HasKey(e => e.Grpnum);

                entity.ToTable("findmefollow");

                entity.Property(e => e.Grpnum)
                    .HasColumnName("grpnum")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.AnnmsgId)
                    .HasColumnName("annmsg_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CalendarEnable)
                    .HasColumnName("calendar_enable")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.CalendarGroupId)
                    .HasColumnName("calendar_group_id")
                    .HasColumnType("varchar(80)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CalendarId)
                    .HasColumnName("calendar_id")
                    .HasColumnType("varchar(80)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CalendarMatch)
                    .HasColumnName("calendar_match")
                    .HasColumnType("varchar(4)")
                    .HasDefaultValueSql("'yes'");

                entity.Property(e => e.Dring)
                    .HasColumnName("dring")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.Grplist)
                    .IsRequired()
                    .HasColumnName("grplist")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.Grppre)
                    .HasColumnName("grppre")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.Grptime)
                    .HasColumnName("grptime")
                    .HasColumnType("smallint(6)");

                entity.Property(e => e.Needsconf)
                    .HasColumnName("needsconf")
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.Postdest)
                    .HasColumnName("postdest")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.PreRing)
                    .HasColumnName("pre_ring")
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.RemotealertId)
                    .HasColumnName("remotealert_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Ringing)
                    .HasColumnName("ringing")
                    .HasColumnType("varchar(80)");

                entity.Property(e => e.Rvolume)
                    .HasColumnName("rvolume")
                    .HasColumnType("varchar(2)");

                entity.Property(e => e.Strategy)
                    .IsRequired()
                    .HasColumnName("strategy")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.ToolateId)
                    .HasColumnName("toolate_id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<FreepbxLog>(entity =>
            {
                entity.ToTable("freepbx_log");

                entity.HasIndex(e => new { e.Time, e.Level })
                    .HasName("time");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Level)
                    .IsRequired()
                    .HasColumnName("level")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("'error'");

                entity.Property(e => e.Message)
                    .IsRequired()
                    .HasColumnName("message")
                    .HasColumnType("longtext");

                entity.Property(e => e.Section)
                    .HasColumnName("section")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Time)
                    .HasColumnName("time")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<FreepbxSettings>(entity =>
            {
                entity.HasKey(e => e.Keyword);

                entity.ToTable("freepbx_settings");

                entity.Property(e => e.Keyword)
                    .HasColumnName("keyword")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Category)
                    .HasColumnName("category")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.Defaultval)
                    .HasColumnName("defaultval")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasColumnType("longtext");

                entity.Property(e => e.Emptyok)
                    .HasColumnName("emptyok")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Hidden)
                    .HasColumnName("hidden")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Level)
                    .HasColumnName("level")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Module)
                    .HasColumnName("module")
                    .HasColumnType("varchar(25)");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasColumnType("varchar(80)");

                entity.Property(e => e.Options)
                    .HasColumnName("options")
                    .HasColumnType("longtext");

                entity.Property(e => e.Readonly)
                    .HasColumnName("readonly")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Sortorder)
                    .HasColumnName("sortorder")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasColumnType("varchar(25)");

                entity.Property(e => e.Value)
                    .HasColumnName("value")
                    .HasColumnType("varchar(255)");
            });

            modelBuilder.Entity<Globals>(entity =>
            {
                entity.HasKey(e => e.Variable);

                entity.ToTable("globals");

                entity.Property(e => e.Variable)
                    .HasColumnName("variable")
                    .HasColumnType("varchar(190)");

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasColumnName("value")
                    .HasColumnType("varchar(255)");
            });

            modelBuilder.Entity<Hotelwakeup>(entity =>
            {
                entity.HasKey(e => e.Maxretries);

                entity.ToTable("hotelwakeup");

                entity.Property(e => e.Maxretries)
                    .HasColumnName("maxretries")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Application)
                    .HasColumnName("application")
                    .HasColumnType("varchar(30)");

                entity.Property(e => e.Cid)
                    .HasColumnName("cid")
                    .HasColumnType("varchar(30)");

                entity.Property(e => e.Cnam)
                    .HasColumnName("cnam")
                    .HasColumnType("varchar(30)");

                entity.Property(e => e.Data)
                    .HasColumnName("data")
                    .HasColumnType("varchar(30)");

                entity.Property(e => e.Extensionlength)
                    .HasColumnName("extensionlength")
                    .HasColumnType("int(11)");

                entity.Property(e => e.OperatorExtensions)
                    .HasColumnName("operator_extensions")
                    .HasColumnType("varchar(30)");

                entity.Property(e => e.OperatorMode)
                    .HasColumnName("operator_mode")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Retrytime)
                    .HasColumnName("retrytime")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Waittime)
                    .HasColumnName("waittime")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<HotelwakeupCalls>(entity =>
            {
                entity.HasKey(e => e.Time);

                entity.ToTable("hotelwakeup_calls");

                entity.Property(e => e.Time)
                    .HasColumnName("time")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Application)
                    .HasColumnName("application")
                    .HasColumnType("varchar(30)");

                entity.Property(e => e.Cid)
                    .HasColumnName("cid")
                    .HasColumnType("varchar(30)");

                entity.Property(e => e.Cnam)
                    .HasColumnName("cnam")
                    .HasColumnType("varchar(30)");

                entity.Property(e => e.Data)
                    .HasColumnName("data")
                    .HasColumnType("varchar(30)");

                entity.Property(e => e.Ext)
                    .HasColumnName("ext")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Filename)
                    .HasColumnName("filename")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.Frequency)
                    .HasColumnName("frequency")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Maxretries)
                    .HasColumnName("maxretries")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Outdir)
                    .HasColumnName("outdir")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.Retrytime)
                    .HasColumnName("retrytime")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Tempdir)
                    .HasColumnName("tempdir")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.Waittime)
                    .HasColumnName("waittime")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<Iax>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.Keyword });

                entity.ToTable("iax");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("varchar(20)")
                    .HasDefaultValueSql("'-1'");

                entity.Property(e => e.Keyword)
                    .HasColumnName("keyword")
                    .HasColumnType("varchar(30)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Data)
                    .IsRequired()
                    .HasColumnName("data")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.Flags)
                    .HasColumnName("flags")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<Iaxsettings>(entity =>
            {
                entity.HasKey(e => new { e.Keyword, e.Seq, e.Type });

                entity.ToTable("iaxsettings");

                entity.Property(e => e.Keyword)
                    .HasColumnName("keyword")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Seq)
                    .HasColumnName("seq")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Data)
                    .IsRequired()
                    .HasColumnName("data")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<IndicationsZonelist>(entity =>
            {
                entity.HasKey(e => e.Iso);

                entity.ToTable("indications_zonelist");

                entity.Property(e => e.Iso)
                    .HasColumnName("iso")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Conf).HasColumnName("conf");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("varchar(80)");
            });

            modelBuilder.Entity<IvrDetails>(entity =>
            {
                entity.ToTable("ivr_details");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Alertinfo)
                    .HasColumnName("alertinfo")
                    .HasColumnType("varchar(150)");

                entity.Property(e => e.Announcement)
                    .HasColumnName("announcement")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasColumnType("varchar(150)");

                entity.Property(e => e.Directdial)
                    .HasColumnName("directdial")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.InvalidAppendAnnounce)
                    .HasColumnName("invalid_append_announce")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.InvalidDestination)
                    .HasColumnName("invalid_destination")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.InvalidIvrRet)
                    .HasColumnName("invalid_ivr_ret")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.InvalidLoops)
                    .HasColumnName("invalid_loops")
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.InvalidRecording)
                    .HasColumnName("invalid_recording")
                    .HasColumnType("varchar(25)");

                entity.Property(e => e.InvalidRetryRecording)
                    .HasColumnName("invalid_retry_recording")
                    .HasColumnType("varchar(25)");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.Retvm)
                    .HasColumnName("retvm")
                    .HasColumnType("varchar(8)");

                entity.Property(e => e.Rvolume)
                    .IsRequired()
                    .HasColumnName("rvolume")
                    .HasColumnType("varchar(2)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.TimeoutAppendAnnounce)
                    .HasColumnName("timeout_append_announce")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.TimeoutDestination)
                    .HasColumnName("timeout_destination")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.TimeoutEnabled)
                    .HasColumnName("timeout_enabled")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.TimeoutIvrRet)
                    .HasColumnName("timeout_ivr_ret")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.TimeoutLoops)
                    .HasColumnName("timeout_loops")
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.TimeoutRecording)
                    .HasColumnName("timeout_recording")
                    .HasColumnType("varchar(25)");

                entity.Property(e => e.TimeoutRetryRecording)
                    .HasColumnName("timeout_retry_recording")
                    .HasColumnType("varchar(25)");

                entity.Property(e => e.TimeoutTime)
                    .HasColumnName("timeout_time")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<Kvblobstore>(entity =>
            {
                entity.HasKey(e => e.Uuid);

                entity.ToTable("kvblobstore");

                entity.Property(e => e.Uuid)
                    .HasColumnName("uuid")
                    .HasColumnType("char(36)");

                entity.Property(e => e.Content).HasColumnName("content");

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasColumnType("char(32)");
            });

            modelBuilder.Entity<Languages>(entity =>
            {
                entity.HasKey(e => e.LanguageId);

                entity.ToTable("languages");

                entity.Property(e => e.LanguageId)
                    .HasColumnName("language_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.Dest)
                    .HasColumnName("dest")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.LangCode)
                    .HasColumnName("lang_code")
                    .HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<LogfileLogfiles>(entity =>
            {
                entity.HasKey(e => e.Name);

                entity.ToTable("logfile_logfiles");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasColumnType("varchar(25)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Debug)
                    .HasColumnName("debug")
                    .HasColumnType("varchar(25)");

                entity.Property(e => e.Dtmf)
                    .HasColumnName("dtmf")
                    .HasColumnType("varchar(25)");

                entity.Property(e => e.Error)
                    .HasColumnName("error")
                    .HasColumnType("varchar(25)");

                entity.Property(e => e.Fax)
                    .HasColumnName("fax")
                    .HasColumnType("varchar(25)");

                entity.Property(e => e.Notice)
                    .HasColumnName("notice")
                    .HasColumnType("varchar(25)");

                entity.Property(e => e.Security)
                    .HasColumnName("security")
                    .HasColumnType("varchar(25)");

                entity.Property(e => e.Verbose)
                    .HasColumnName("verbose")
                    .HasColumnType("varchar(25)");

                entity.Property(e => e.Warning)
                    .HasColumnName("warning")
                    .HasColumnType("varchar(25)");
            });

            modelBuilder.Entity<LogfileSettings>(entity =>
            {
                entity.HasKey(e => e.Key);

                entity.ToTable("logfile_settings");

                entity.Property(e => e.Key)
                    .HasColumnName("key")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Value)
                    .HasColumnName("value")
                    .HasColumnType("varchar(255)");
            });

            modelBuilder.Entity<Manager>(entity =>
            {
                entity.ToTable("manager");

                entity.Property(e => e.ManagerId)
                    .HasColumnName("manager_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Deny)
                    .HasColumnName("deny")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("varchar(15)");

                entity.Property(e => e.Permit)
                    .HasColumnName("permit")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.Read)
                    .HasColumnName("read")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.Secret)
                    .HasColumnName("secret")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.Write)
                    .HasColumnName("write")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.Writetimeout)
                    .HasColumnName("writetimeout")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<Meetme>(entity =>
            {
                entity.HasKey(e => e.Exten);

                entity.ToTable("meetme");

                entity.Property(e => e.Exten)
                    .HasColumnName("exten")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.Adminpin)
                    .HasColumnName("adminpin")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.JoinmsgId)
                    .HasColumnName("joinmsg_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Language)
                    .IsRequired()
                    .HasColumnName("language")
                    .HasColumnType("varchar(10)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Music)
                    .HasColumnName("music")
                    .HasColumnType("varchar(80)");

                entity.Property(e => e.Options)
                    .HasColumnName("options")
                    .HasColumnType("varchar(15)");

                entity.Property(e => e.Timeout)
                    .HasColumnName("timeout")
                    .HasDefaultValueSql("'21600'");

                entity.Property(e => e.Userpin)
                    .HasColumnName("userpin")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.Users)
                    .HasColumnName("users")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<Miscapps>(entity =>
            {
                entity.ToTable("miscapps");

                entity.Property(e => e.MiscappsId)
                    .HasColumnName("miscapps_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.Dest)
                    .HasColumnName("dest")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.Ext)
                    .HasColumnName("ext")
                    .HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<Miscdests>(entity =>
            {
                entity.ToTable("miscdests");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.Destdial)
                    .IsRequired()
                    .HasColumnName("destdial")
                    .HasColumnType("varchar(100)");
            });

            modelBuilder.Entity<Modules>(entity =>
            {
                entity.ToTable("modules");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Enabled)
                    .HasColumnName("enabled")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Modulename)
                    .IsRequired()
                    .HasColumnName("modulename")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Signature).HasColumnName("signature");

                entity.Property(e => e.Version)
                    .IsRequired()
                    .HasColumnName("version")
                    .HasColumnType("varchar(20)")
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<ModuleXml>(entity =>
            {
                entity.ToTable("module_xml");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("varchar(20)")
                    .HasDefaultValueSql("'xml'");

                entity.Property(e => e.Data).HasColumnName("data");

                entity.Property(e => e.Time)
                    .HasColumnName("time")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<Motif>(entity =>
            {
                entity.ToTable("motif");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Authmode)
                    .IsRequired()
                    .HasColumnName("authmode")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("'plaintext'");

                entity.Property(e => e.OauthClientid)
                    .IsRequired()
                    .HasColumnName("oauth_clientid")
                    .HasColumnType("varchar(150)");

                entity.Property(e => e.OauthSecret)
                    .IsRequired()
                    .HasColumnName("oauth_secret")
                    .HasColumnType("varchar(150)");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasColumnName("password")
                    .HasColumnType("varchar(150)");

                entity.Property(e => e.Phonenum)
                    .IsRequired()
                    .HasColumnName("phonenum")
                    .HasColumnType("varchar(12)");

                entity.Property(e => e.Priority)
                    .HasColumnName("priority")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'127'");

                entity.Property(e => e.RefreshToken)
                    .IsRequired()
                    .HasColumnName("refresh_token")
                    .HasColumnType("varchar(150)");

                entity.Property(e => e.Settings)
                    .IsRequired()
                    .HasColumnName("settings");

                entity.Property(e => e.Statusmessage)
                    .IsRequired()
                    .HasColumnName("statusmessage")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasColumnName("type")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("'googlevoice'");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasColumnName("username")
                    .HasColumnType("varchar(100)");
            });

            modelBuilder.Entity<Music>(entity =>
            {
                entity.ToTable("music");

                entity.HasIndex(e => e.Category)
                    .HasName("category_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Application)
                    .HasColumnName("application")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.Category)
                    .HasColumnName("category")
                    .HasColumnType("varchar(190)");

                entity.Property(e => e.Format)
                    .HasColumnName("format")
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.Random)
                    .HasColumnName("random")
                    .HasColumnType("tinyint(1)");

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasColumnType("varchar(100)");
            });

            modelBuilder.Entity<Notifications>(entity =>
            {
                entity.HasKey(e => new { e.Module, e.Id });

                entity.ToTable("notifications");

                entity.Property(e => e.Module)
                    .HasColumnName("module")
                    .HasColumnType("varchar(24)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("varchar(24)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Candelete)
                    .HasColumnName("candelete")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.DisplayText)
                    .IsRequired()
                    .HasColumnName("display_text")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ExtendedText)
                    .IsRequired()
                    .HasColumnName("extended_text");

                entity.Property(e => e.Level)
                    .HasColumnName("level")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Link)
                    .IsRequired()
                    .HasColumnName("link")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Reset)
                    .HasColumnName("reset")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Timestamp)
                    .HasColumnName("timestamp")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<OutboundRoutePatterns>(entity =>
            {
                entity.HasKey(e => new { e.RouteId, e.MatchPatternPrefix, e.MatchPatternPass, e.MatchCid, e.PrependDigits });

                entity.ToTable("outbound_route_patterns");

                entity.Property(e => e.RouteId)
                    .HasColumnName("route_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MatchPatternPrefix)
                    .HasColumnName("match_pattern_prefix")
                    .HasColumnType("varchar(60)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.MatchPatternPass)
                    .HasColumnName("match_pattern_pass")
                    .HasColumnType("varchar(60)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.MatchCid)
                    .HasColumnName("match_cid")
                    .HasColumnType("varchar(60)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.PrependDigits)
                    .HasColumnName("prepend_digits")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<OutboundRoutes>(entity =>
            {
                entity.HasKey(e => e.RouteId);

                entity.ToTable("outbound_routes");

                entity.Property(e => e.RouteId)
                    .HasColumnName("route_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CalendarGroupId)
                    .HasColumnName("calendar_group_id")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.CalendarId)
                    .HasColumnName("calendar_id")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.Dest)
                    .HasColumnName("dest")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.EmergencyRoute)
                    .HasColumnName("emergency_route")
                    .HasColumnType("varchar(4)");

                entity.Property(e => e.IntracompanyRoute)
                    .HasColumnName("intracompany_route")
                    .HasColumnType("varchar(4)");

                entity.Property(e => e.Mohclass)
                    .HasColumnName("mohclass")
                    .HasColumnType("varchar(80)");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasColumnType("varchar(40)");

                entity.Property(e => e.Outcid)
                    .HasColumnName("outcid")
                    .HasColumnType("varchar(40)");

                entity.Property(e => e.OutcidMode)
                    .HasColumnName("outcid_mode")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Password)
                    .HasColumnName("password")
                    .HasColumnType("varchar(30)");

                entity.Property(e => e.TimeGroupId)
                    .HasColumnName("time_group_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.TimeMode)
                    .HasColumnName("time_mode")
                    .HasColumnType("varchar(20)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Timezone)
                    .HasColumnName("timezone")
                    .HasColumnType("varchar(255)");
            });

            modelBuilder.Entity<OutboundRouteSequence>(entity =>
            {
                entity.HasKey(e => new { e.RouteId, e.Seq });

                entity.ToTable("outbound_route_sequence");

                entity.Property(e => e.RouteId)
                    .HasColumnName("route_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Seq)
                    .HasColumnName("seq")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<OutboundRouteTrunks>(entity =>
            {
                entity.HasKey(e => new { e.RouteId, e.TrunkId, e.Seq });

                entity.ToTable("outbound_route_trunks");

                entity.Property(e => e.RouteId)
                    .HasColumnName("route_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.TrunkId)
                    .HasColumnName("trunk_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Seq)
                    .HasColumnName("seq")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<Outroutemsg>(entity =>
            {
                entity.HasKey(e => e.Keyword);

                entity.ToTable("outroutemsg");

                entity.Property(e => e.Keyword)
                    .HasColumnName("keyword")
                    .HasColumnType("varchar(40)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Data)
                    .IsRequired()
                    .HasColumnName("data")
                    .HasColumnType("varchar(10)");
            });

            modelBuilder.Entity<PagingAutoanswer>(entity =>
            {
                entity.HasKey(e => new { e.Useragent, e.Var });

                entity.ToTable("paging_autoanswer");

                entity.Property(e => e.Useragent)
                    .HasColumnName("useragent")
                    .HasColumnType("varchar(190)");

                entity.Property(e => e.Var)
                    .HasColumnName("var")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Setting)
                    .IsRequired()
                    .HasColumnName("setting")
                    .HasColumnType("varchar(255)");
            });

            modelBuilder.Entity<PagingConfig>(entity =>
            {
                entity.HasKey(e => e.PageGroup);

                entity.ToTable("paging_config");

                entity.Property(e => e.PageGroup)
                    .HasColumnName("page_group")
                    .HasColumnType("varchar(190)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Announcement)
                    .HasColumnName("announcement")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Duplex)
                    .HasColumnName("duplex")
                    .HasColumnType("int(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.ForcePage)
                    .HasColumnName("force_page")
                    .HasColumnType("int(1)");

                entity.Property(e => e.Volume)
                    .HasColumnName("volume")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<PagingGroups>(entity =>
            {
                entity.HasKey(e => new { e.PageNumber, e.Ext });

                entity.ToTable("paging_groups");

                entity.Property(e => e.PageNumber)
                    .HasColumnName("page_number")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Ext)
                    .HasColumnName("ext")
                    .HasColumnType("varchar(25)")
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<Pagingpro>(entity =>
            {
                entity.HasKey(e => e.PageId);

                entity.ToTable("pagingpro");

                entity.Property(e => e.PageId)
                    .HasColumnName("page_id")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Autoanswer)
                    .HasColumnName("autoanswer")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Busypage)
                    .HasColumnName("busypage")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.CalendarGroupId)
                    .HasColumnName("calendar_group_id")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("'100'");

                entity.Property(e => e.CalendarId)
                    .HasColumnName("calendar_id")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("'100'");

                entity.Property(e => e.CidPrepend)
                    .HasColumnName("cid_prepend")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.EnableCalendar)
                    .HasColumnName("enable_calendar")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.EnableScheduler)
                    .HasColumnName("enable_scheduler")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.IntroRecording)
                    .HasColumnName("intro_recording")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.Timezone)
                    .HasColumnName("timezone")
                    .HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<PagingproCoreRouting>(entity =>
            {
                entity.HasKey(e => e.Route);

                entity.ToTable("pagingpro_core_routing");

                entity.Property(e => e.Route)
                    .HasColumnName("route")
                    .HasColumnType("varchar(25)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.PageId)
                    .HasColumnName("page_id")
                    .HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<Parkplus>(entity =>
            {
                entity.ToTable("parkplus");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.Alertinfo)
                    .IsRequired()
                    .HasColumnName("alertinfo")
                    .HasColumnType("varchar(254)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.AnnouncementId)
                    .HasColumnName("announcement_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Autocidpp)
                    .IsRequired()
                    .HasColumnName("autocidpp")
                    .HasColumnType("varchar(10)")
                    .HasDefaultValueSql("'none'");

                entity.Property(e => e.Cidpp)
                    .IsRequired()
                    .HasColumnName("cidpp")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Comebacktoorigin)
                    .IsRequired()
                    .HasColumnName("comebacktoorigin")
                    .HasColumnType("varchar(10)")
                    .HasDefaultValueSql("'yes'");

                entity.Property(e => e.Defaultlot)
                    .IsRequired()
                    .HasColumnName("defaultlot")
                    .HasColumnType("varchar(10)")
                    .HasDefaultValueSql("'no'");

                entity.Property(e => e.Dest)
                    .IsRequired()
                    .HasColumnName("dest")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("'app-blackhole,hangup,1'");

                entity.Property(e => e.Findslot)
                    .IsRequired()
                    .HasColumnName("findslot")
                    .HasColumnType("varchar(10)")
                    .HasDefaultValueSql("'first'");

                entity.Property(e => e.Generatefc)
                    .IsRequired()
                    .HasColumnName("generatefc")
                    .HasColumnType("varchar(10)")
                    .HasDefaultValueSql("'yes'");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("varchar(40)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Numslots)
                    .HasColumnName("numslots")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'4'");

                entity.Property(e => e.Parkedcallreparking)
                    .IsRequired()
                    .HasColumnName("parkedcallreparking")
                    .HasColumnType("varchar(10)")
                    .HasDefaultValueSql("'caller'");

                entity.Property(e => e.Parkedcalltransfers)
                    .IsRequired()
                    .HasColumnName("parkedcalltransfers")
                    .HasColumnType("varchar(10)")
                    .HasDefaultValueSql("'caller'");

                entity.Property(e => e.Parkedmusicclass)
                    .HasColumnName("parkedmusicclass")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("'default'");

                entity.Property(e => e.Parkedplay)
                    .IsRequired()
                    .HasColumnName("parkedplay")
                    .HasColumnType("varchar(10)")
                    .HasDefaultValueSql("'both'");

                entity.Property(e => e.Parkext)
                    .IsRequired()
                    .HasColumnName("parkext")
                    .HasColumnType("varchar(40)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Parkingtime)
                    .HasColumnName("parkingtime")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'45'");

                entity.Property(e => e.Parkpos)
                    .IsRequired()
                    .HasColumnName("parkpos")
                    .HasColumnType("varchar(40)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Rvolume)
                    .IsRequired()
                    .HasColumnName("rvolume")
                    .HasColumnType("varchar(2)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasColumnName("type")
                    .HasColumnType("varchar(10)")
                    .HasDefaultValueSql("'public'");
            });

            modelBuilder.Entity<ParkplusAnnounce>(entity =>
            {
                entity.ToTable("parkplus_announce");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AnnounceOrder).HasColumnName("announce_order");

                entity.Property(e => e.AnnounceRepeat)
                    .HasColumnName("announce_repeat")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Announceext)
                    .IsRequired()
                    .HasColumnName("announceext")
                    .HasColumnType("varchar(40)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Autocidpp)
                    .IsRequired()
                    .HasColumnName("autocidpp")
                    .HasColumnType("varchar(10)")
                    .HasDefaultValueSql("'none'");

                entity.Property(e => e.Cidpp)
                    .IsRequired()
                    .HasColumnName("cidpp")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Comebacktoorigin)
                    .IsRequired()
                    .HasColumnName("comebacktoorigin")
                    .HasColumnType("varchar(10)")
                    .HasDefaultValueSql("'yes'");

                entity.Property(e => e.Dest)
                    .IsRequired()
                    .HasColumnName("dest")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.FailureRecordingId)
                    .HasColumnName("failure_recording_id")
                    .HasColumnType("varchar(45)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("varchar(40)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.PageAnnouncementId)
                    .HasColumnName("page_announcement_id")
                    .HasColumnType("varchar(45)");

                entity.Property(e => e.PageAnnouncementId1)
                    .HasColumnName("page_announcement_id_1")
                    .HasColumnType("varchar(45)");

                entity.Property(e => e.PageAnnouncementId2)
                    .HasColumnName("page_announcement_id_2")
                    .HasColumnType("varchar(45)");

                entity.Property(e => e.PageAnnouncementId3)
                    .HasColumnName("page_announcement_id_3")
                    .HasColumnType("varchar(45)");

                entity.Property(e => e.PageId)
                    .IsRequired()
                    .HasColumnName("page_id")
                    .HasColumnType("varchar(16)");

                entity.Property(e => e.PageTimerExtend)
                    .HasColumnName("page_timer_extend")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.ParkId)
                    .HasColumnName("park_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Parkingretry)
                    .HasColumnName("parkingretry")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Parkingtime)
                    .HasColumnName("parkingtime")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'45'");

                entity.Property(e => e.ParkingtimeEnable)
                    .HasColumnName("parkingtime_enable")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.PrimaryAnnouncementId)
                    .HasColumnName("primary_announcement_id")
                    .HasColumnType("varchar(45)");

                entity.Property(e => e.RecordAnnouncementId)
                    .HasColumnName("record_announcement_id")
                    .HasColumnType("varchar(45)");

                entity.Property(e => e.RecordMessage)
                    .IsRequired()
                    .HasColumnName("record_message")
                    .HasColumnType("varchar(10)")
                    .HasDefaultValueSql("'no'");

                entity.Property(e => e.RecordMessageLength)
                    .HasColumnName("record_message_length")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'5'");

                entity.Property(e => e.RecordMessageSilence)
                    .HasColumnName("record_message_silence")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'3'");

                entity.Property(e => e.ReplaceAnnouncementId)
                    .HasColumnName("replace_announcement_id")
                    .HasColumnType("varchar(45)");

                entity.Property(e => e.SlotAnnounceEnable)
                    .IsRequired()
                    .HasColumnName("slot_announce_enable")
                    .HasColumnType("varchar(10)")
                    .HasDefaultValueSql("'yes'");

                entity.Property(e => e.SuccessfulRecordingId)
                    .HasColumnName("successful_recording_id")
                    .HasColumnType("varchar(45)");
            });

            modelBuilder.Entity<ParkplusDevice>(entity =>
            {
                entity.HasKey(e => e.DeviceId);

                entity.ToTable("parkplus_device");

                entity.Property(e => e.DeviceId)
                    .HasColumnName("device_id")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.ParkplusId)
                    .HasColumnName("parkplus_id")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'1'");
            });

            modelBuilder.Entity<Pinsets>(entity =>
            {
                entity.ToTable("pinsets");

                entity.Property(e => e.PinsetsId)
                    .HasColumnName("pinsets_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Addtocdr)
                    .HasColumnName("addtocdr")
                    .HasColumnType("tinyint(1)");

                entity.Property(e => e.Deptname)
                    .HasColumnName("deptname")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.Passwords)
                    .HasColumnName("passwords")
                    .HasColumnType("longtext");
            });

            modelBuilder.Entity<PinsetUsage>(entity =>
            {
                entity.HasKey(e => new { e.Dispname, e.ForeignId });

                entity.ToTable("pinset_usage");

                entity.Property(e => e.Dispname)
                    .HasColumnName("dispname")
                    .HasColumnType("varchar(30)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ForeignId)
                    .HasColumnName("foreign_id")
                    .HasColumnType("varchar(30)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.PinsetsId)
                    .HasColumnName("pinsets_id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<Pjsip>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.Keyword });

                entity.ToTable("pjsip");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("varchar(20)")
                    .HasDefaultValueSql("'-1'");

                entity.Property(e => e.Keyword)
                    .HasColumnName("keyword")
                    .HasColumnType("varchar(30)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Data)
                    .IsRequired()
                    .HasColumnName("data")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.Flags)
                    .HasColumnName("flags")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<PresencestateList>(entity =>
            {
                entity.ToTable("presencestate_list");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Message)
                    .HasColumnName("message")
                    .HasColumnType("varchar(80)");

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasColumnType("varchar(25)");
            });

            modelBuilder.Entity<PresencestatePrefs>(entity =>
            {
                entity.HasKey(e => new { e.Extension, e.ItemId });

                entity.ToTable("presencestate_prefs");

                entity.Property(e => e.Extension)
                    .HasColumnName("extension")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.ItemId)
                    .HasColumnName("item_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Pref)
                    .HasColumnName("pref")
                    .HasColumnType("varchar(25)");
            });

            modelBuilder.Entity<QsAgentlog>(entity =>
            {
                entity.ToTable("qs_agentlog");

                entity.HasIndex(e => e.Agentid)
                    .HasName("agent");

                entity.HasIndex(e => e.Event)
                    .HasName("eventindex");

                entity.HasIndex(e => new { e.Event, e.Eventstart, e.Eventend })
                    .HasName("fullindex");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.Agentid)
                    .IsRequired()
                    .HasColumnName("agentid")
                    .HasColumnType("varchar(64)");

                entity.Property(e => e.Event)
                    .IsRequired()
                    .HasColumnName("event")
                    .HasColumnType("varchar(64)");

                entity.Property(e => e.Eventdata)
                    .IsRequired()
                    .HasColumnName("eventdata")
                    .HasColumnType("varchar(32)");

                entity.Property(e => e.Eventend)
                    .HasColumnName("eventend")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Eventlength)
                    .HasColumnName("eventlength")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Eventstart)
                    .HasColumnName("eventstart")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Queuename)
                    .IsRequired()
                    .HasColumnName("queuename")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Serverid)
                    .IsRequired()
                    .HasColumnName("serverid")
                    .HasColumnType("varchar(36)");
            });

            modelBuilder.Entity<QsAgentstats>(entity =>
            {
                entity.ToTable("qs_agentstats");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.Agentid)
                    .IsRequired()
                    .HasColumnName("agentid")
                    .HasColumnType("varchar(64)");

                entity.Property(e => e.Answeredcalls)
                    .HasColumnName("answeredcalls")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Avgtalktime)
                    .HasColumnName("avgtalktime")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Completedcalls)
                    .HasColumnName("completedcalls")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Idlesec)
                    .HasColumnName("idlesec")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Maxtalkcallid)
                    .IsRequired()
                    .HasColumnName("maxtalkcallid")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Maxtalktime)
                    .HasColumnName("maxtalktime")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Mintalkcallid)
                    .IsRequired()
                    .HasColumnName("mintalkcallid")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Mintalktime)
                    .HasColumnName("mintalktime")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Missedcalls)
                    .HasColumnName("missedcalls")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Pausedsec)
                    .HasColumnName("pausedsec")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Serverid)
                    .IsRequired()
                    .HasColumnName("serverid")
                    .HasColumnType("varchar(36)");

                entity.Property(e => e.Statend)
                    .HasColumnName("statend")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Statstart)
                    .HasColumnName("statstart")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Talksec)
                    .HasColumnName("talksec")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Wrapupsec)
                    .HasColumnName("wrapupsec")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<QsCallstats>(entity =>
            {
                entity.HasKey(e => e.Callid);

                entity.ToTable("qs_callstats");

                entity.HasIndex(e => e.Answertime)
                    .HasName("answerindex");

                entity.HasIndex(e => e.Entrytime)
                    .HasName("startindex");

                entity.HasIndex(e => e.Lasteventtime)
                    .HasName("endindex");

                entity.HasIndex(e => e.Relatedcallid)
                    .HasName("relatedindex");

                entity.HasIndex(e => e.Status)
                    .HasName("callstatus");

                entity.Property(e => e.Callid)
                    .HasColumnName("callid")
                    .HasColumnType("varchar(32)");

                entity.Property(e => e.Agentname)
                    .IsRequired()
                    .HasColumnName("agentname")
                    .HasColumnType("varchar(40)");

                entity.Property(e => e.Answertime)
                    .HasColumnName("answertime")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Callerid)
                    .IsRequired()
                    .HasColumnName("callerid")
                    .HasColumnType("varchar(32)");

                entity.Property(e => e.Complete)
                    .HasColumnName("complete")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Completetime)
                    .HasColumnName("completetime")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Did)
                    .IsRequired()
                    .HasColumnName("did")
                    .HasColumnType("varchar(32)");

                entity.Property(e => e.Entryposition)
                    .HasColumnName("entryposition")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Entrytime)
                    .HasColumnName("entrytime")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Holdtime)
                    .HasColumnName("holdtime")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Lastevent)
                    .IsRequired()
                    .HasColumnName("lastevent")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Lasteventid)
                    .HasColumnName("lasteventid")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Lasteventtime)
                    .HasColumnName("lasteventtime")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Queuename)
                    .IsRequired()
                    .HasColumnName("queuename")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Relatedcallid)
                    .IsRequired()
                    .HasColumnName("relatedcallid")
                    .HasColumnType("varchar(32)");

                entity.Property(e => e.Serverid)
                    .IsRequired()
                    .HasColumnName("serverid")
                    .HasColumnType("varchar(36)");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Talktime)
                    .HasColumnName("talktime")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<QsLivestats>(entity =>
            {
                entity.HasKey(e => e.Uuid);

                entity.ToTable("qs_livestats");

                entity.HasIndex(e => e.Timestamp)
                    .HasName("ts_indexs");

                entity.Property(e => e.Uuid)
                    .HasColumnName("uuid")
                    .HasColumnType("varchar(42)");

                entity.Property(e => e.Serverid)
                    .IsRequired()
                    .HasColumnName("serverid")
                    .HasColumnType("varchar(36)");

                entity.Property(e => e.Timestamp)
                    .HasColumnName("timestamp")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<QsQueuestats>(entity =>
            {
                entity.ToTable("qs_queuestats");

                entity.HasIndex(e => new { e.Periodstart, e.Periodend })
                    .HasName("periodindex");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.Abandoned)
                    .HasColumnName("abandoned")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Activecalls)
                    .HasColumnName("activecalls")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Agentsavail)
                    .HasColumnName("agentsavail")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Agentsinuse)
                    .HasColumnName("agentsinuse")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Agentsunavail)
                    .HasColumnName("agentsunavail")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Answeredcalls)
                    .HasColumnName("answeredcalls")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Averageholdsec)
                    .HasColumnName("averageholdsec")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Averagetalksec)
                    .HasColumnName("averagetalksec")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Callswaiting)
                    .HasColumnName("callswaiting")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Completedcalls)
                    .HasColumnName("completedcalls")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Incomingcalls)
                    .HasColumnName("incomingcalls")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Ivrabandoned)
                    .HasColumnName("ivrabandoned")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Longestholdid)
                    .IsRequired()
                    .HasColumnName("longestholdid")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Longestholdsec)
                    .HasColumnName("longestholdsec")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Longesttalkid)
                    .IsRequired()
                    .HasColumnName("longesttalkid")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Longesttalksec)
                    .HasColumnName("longesttalksec")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Periodend)
                    .HasColumnName("periodend")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Periodstart)
                    .HasColumnName("periodstart")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Queuename)
                    .IsRequired()
                    .HasColumnName("queuename")
                    .HasColumnType("varchar(64)");

                entity.Property(e => e.Serverid)
                    .IsRequired()
                    .HasColumnName("serverid")
                    .HasColumnType("varchar(36)");

                entity.Property(e => e.Shortestholdid)
                    .IsRequired()
                    .HasColumnName("shortestholdid")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Shortestholdsec)
                    .HasColumnName("shortestholdsec")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Shortesttalkid)
                    .IsRequired()
                    .HasColumnName("shortesttalkid")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Shortesttalksec)
                    .HasColumnName("shortesttalksec")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Slapercent)
                    .HasColumnName("slapercent")
                    .HasColumnType("decimal(10,5)");

                entity.Property(e => e.Totalagents)
                    .HasColumnName("totalagents")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<Queueprio>(entity =>
            {
                entity.ToTable("queueprio");

                entity.Property(e => e.QueueprioId)
                    .HasColumnName("queueprio_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.Dest)
                    .HasColumnName("dest")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.QueuePriority)
                    .HasColumnName("queue_priority")
                    .HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<QueuesConfig>(entity =>
            {
                entity.HasKey(e => e.Extension);

                entity.ToTable("queues_config");

                entity.Property(e => e.Extension)
                    .HasColumnName("extension")
                    .HasColumnType("varchar(20)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.AgentannounceId)
                    .HasColumnName("agentannounce_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Alertinfo)
                    .IsRequired()
                    .HasColumnName("alertinfo")
                    .HasColumnType("varchar(254)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CallbackId)
                    .IsRequired()
                    .HasColumnName("callback_id")
                    .HasColumnType("varchar(8)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Callconfirm)
                    .HasColumnName("callconfirm")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.CallconfirmId)
                    .HasColumnName("callconfirm_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Cwignore)
                    .HasColumnName("cwignore")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Descr)
                    .IsRequired()
                    .HasColumnName("descr")
                    .HasColumnType("varchar(35)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Dest)
                    .IsRequired()
                    .HasColumnName("dest")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Grppre)
                    .IsRequired()
                    .HasColumnName("grppre")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.IvrId)
                    .IsRequired()
                    .HasColumnName("ivr_id")
                    .HasColumnType("varchar(8)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.JoinannounceId)
                    .HasColumnName("joinannounce_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Maxwait)
                    .IsRequired()
                    .HasColumnName("maxwait")
                    .HasColumnType("varchar(8)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.MonitorHeard)
                    .HasColumnName("monitor_heard")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MonitorSpoken)
                    .HasColumnName("monitor_spoken")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MonitorType)
                    .HasColumnName("monitor_type")
                    .HasColumnType("varchar(5)");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasColumnName("password")
                    .HasColumnType("varchar(20)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Qnoanswer)
                    .HasColumnName("qnoanswer")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Qregex)
                    .HasColumnName("qregex")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.Queuewait)
                    .HasColumnName("queuewait")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Ringing)
                    .HasColumnName("ringing")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Togglehint)
                    .HasColumnName("togglehint")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.UseQueueContext)
                    .HasColumnName("use_queue_context")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<QueuesDetails>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.Keyword, e.Data });

                entity.ToTable("queues_details");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("varchar(45)")
                    .HasDefaultValueSql("'-1'");

                entity.Property(e => e.Keyword)
                    .HasColumnName("keyword")
                    .HasColumnType("varchar(30)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Data)
                    .HasColumnName("data")
                    .HasColumnType("varchar(150)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Flags)
                    .HasColumnName("flags")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<Recordings>(entity =>
            {
                entity.ToTable("recordings");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasColumnType("varchar(254)");

                entity.Property(e => e.Displayname)
                    .HasColumnName("displayname")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.Fcode)
                    .HasColumnName("fcode")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.FcodePass)
                    .HasColumnName("fcode_pass")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Filename)
                    .HasColumnName("filename")
                    .HasColumnType("blob");
            });

            modelBuilder.Entity<RestappsSettings>(entity =>
            {
                entity.HasKey(e => new { e.Module, e.Key });

                entity.ToTable("restapps_settings");

                entity.Property(e => e.Module)
                    .HasColumnName("module")
                    .HasColumnType("varchar(25)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Key)
                    .HasColumnName("key")
                    .HasColumnType("varchar(25)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Value)
                    .HasColumnName("value")
                    .HasColumnType("varchar(80)");
            });

            modelBuilder.Entity<Ringgroups>(entity =>
            {
                entity.HasKey(e => e.Grpnum);

                entity.ToTable("ringgroups");

                entity.Property(e => e.Grpnum)
                    .HasColumnName("grpnum")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Alertinfo)
                    .HasColumnName("alertinfo")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.AnnmsgId)
                    .HasColumnName("annmsg_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Cfignore)
                    .HasColumnName("cfignore")
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.Cpickup)
                    .HasColumnName("cpickup")
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.Cwignore)
                    .HasColumnName("cwignore")
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description")
                    .HasColumnType("varchar(35)");

                entity.Property(e => e.Elsewhere)
                    .HasColumnName("elsewhere")
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.Grplist)
                    .IsRequired()
                    .HasColumnName("grplist")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.Grppre)
                    .HasColumnName("grppre")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.Grptime)
                    .HasColumnName("grptime")
                    .HasColumnType("smallint(6)");

                entity.Property(e => e.Needsconf)
                    .HasColumnName("needsconf")
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.Postdest)
                    .HasColumnName("postdest")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.Progress)
                    .HasColumnName("progress")
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.Recording)
                    .HasColumnName("recording")
                    .HasColumnType("varchar(10)")
                    .HasDefaultValueSql("'dontcare'");

                entity.Property(e => e.RemotealertId)
                    .HasColumnName("remotealert_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Ringing)
                    .HasColumnName("ringing")
                    .HasColumnType("varchar(80)");

                entity.Property(e => e.Rvolume)
                    .IsRequired()
                    .HasColumnName("rvolume")
                    .HasColumnType("varchar(2)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Strategy)
                    .IsRequired()
                    .HasColumnName("strategy")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.ToolateId)
                    .HasColumnName("toolate_id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<SangomacrmRestWebhooks>(entity =>
            {
                entity.ToTable("sangomacrm_rest_webhooks");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Direction)
                    .IsRequired()
                    .HasColumnName("direction")
                    .HasColumnType("varchar(12)");

                entity.Property(e => e.Url)
                    .IsRequired()
                    .HasColumnName("url")
                    .HasColumnType("varchar(512)");
            });

            modelBuilder.Entity<SangomarcrmSalesforceUsers>(entity =>
            {
                entity.HasKey(e => e.Uuid);

                entity.ToTable("sangomarcrm_salesforce_users");

                entity.Property(e => e.Uuid)
                    .HasColumnName("uuid")
                    .HasColumnType("varchar(150)");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("email")
                    .HasColumnType("varchar(150)");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasColumnName("first_name")
                    .HasColumnType("varchar(150)");

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasColumnName("last_name")
                    .HasColumnType("varchar(150)");

                entity.Property(e => e.Uid)
                    .HasColumnName("uid")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasColumnName("username")
                    .HasColumnType("varchar(150)");
            });

            modelBuilder.Entity<SangomarcrmSuitecrmUsers>(entity =>
            {
                entity.HasKey(e => e.Uuid);

                entity.ToTable("sangomarcrm_suitecrm_users");

                entity.Property(e => e.Uuid)
                    .HasColumnName("uuid")
                    .HasColumnType("varchar(150)");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasColumnName("first_name")
                    .HasColumnType("varchar(150)");

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasColumnName("last_name")
                    .HasColumnType("varchar(150)");

                entity.Property(e => e.Uid)
                    .HasColumnName("uid")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasColumnName("username")
                    .HasColumnType("varchar(150)");
            });

            modelBuilder.Entity<SangomarcrmZohoUsers>(entity =>
            {
                entity.HasKey(e => e.Uuid);

                entity.ToTable("sangomarcrm_zoho_users");

                entity.Property(e => e.Uuid)
                    .HasColumnName("uuid")
                    .HasColumnType("varchar(150)");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("email")
                    .HasColumnType("varchar(150)");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasColumnName("first_name")
                    .HasColumnType("varchar(150)");

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasColumnName("last_name")
                    .HasColumnType("varchar(150)");

                entity.Property(e => e.Uid)
                    .HasColumnName("uid")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasColumnName("username")
                    .HasColumnType("varchar(150)");
            });

            modelBuilder.Entity<Setcid>(entity =>
            {
                entity.HasKey(e => e.CidId);

                entity.ToTable("setcid");

                entity.Property(e => e.CidId)
                    .HasColumnName("cid_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CidName)
                    .HasColumnName("cid_name")
                    .HasColumnType("varchar(150)");

                entity.Property(e => e.CidNum)
                    .HasColumnName("cid_num")
                    .HasColumnType("varchar(150)");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.Dest)
                    .HasColumnName("dest")
                    .HasColumnType("varchar(255)");
            });

            modelBuilder.Entity<Sip>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.Keyword });

                entity.ToTable("sip");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("varchar(20)")
                    .HasDefaultValueSql("'-1'");

                entity.Property(e => e.Keyword)
                    .HasColumnName("keyword")
                    .HasColumnType("varchar(30)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Data)
                    .IsRequired()
                    .HasColumnName("data")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.Flags)
                    .HasColumnName("flags")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<Sipsettings>(entity =>
            {
                entity.HasKey(e => new { e.Keyword, e.Seq, e.Type });

                entity.ToTable("sipsettings");

                entity.Property(e => e.Keyword)
                    .HasColumnName("keyword")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Seq)
                    .HasColumnName("seq")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Data)
                    .IsRequired()
                    .HasColumnName("data")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<SmsDids>(entity =>
            {
                entity.ToTable("sms_dids");

                entity.HasIndex(e => e.Did)
                    .HasName("did")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Did)
                    .IsRequired()
                    .HasColumnName("did")
                    .HasColumnType("varchar(45)");
            });

            modelBuilder.Entity<SmsMedia>(entity =>
            {
                entity.ToTable("sms_media");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Mid)
                    .HasColumnName("mid")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.Raw)
                    .IsRequired()
                    .HasColumnName("raw");
            });

            modelBuilder.Entity<SmsMessages>(entity =>
            {
                entity.ToTable("sms_messages");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Adaptor)
                    .HasColumnName("adaptor")
                    .HasColumnType("varchar(45)");

                entity.Property(e => e.Body)
                    .IsRequired()
                    .HasColumnName("body")
                    .HasColumnType("varchar(1600)");

                entity.Property(e => e.Cnam)
                    .HasColumnName("cnam")
                    .HasColumnType("varchar(40)");

                entity.Property(e => e.Delivered)
                    .HasColumnName("delivered")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Didid)
                    .HasColumnName("didid")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Direction)
                    .IsRequired()
                    .HasColumnName("direction")
                    .HasColumnType("varchar(3)");

                entity.Property(e => e.Emid)
                    .HasColumnName("emid")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.From)
                    .IsRequired()
                    .HasColumnName("from")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Read)
                    .HasColumnName("read")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Threadid)
                    .IsRequired()
                    .HasColumnName("threadid")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.Timestamp)
                    .HasColumnName("timestamp")
                    .HasColumnType("int(11)");

                entity.Property(e => e.To)
                    .IsRequired()
                    .HasColumnName("to")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.TxRxDatetime)
                    .HasColumnName("tx_rx_datetime")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<SmsRouting>(entity =>
            {
                entity.ToTable("sms_routing");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Accepter)
                    .HasColumnName("accepter")
                    .HasColumnType("varchar(45)");

                entity.Property(e => e.Adaptor)
                    .HasColumnName("adaptor")
                    .HasColumnType("varchar(45)");

                entity.Property(e => e.Did)
                    .IsRequired()
                    .HasColumnName("did")
                    .HasColumnType("varchar(45)");

                entity.Property(e => e.Didid)
                    .HasColumnName("didid")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Uid)
                    .HasColumnName("uid")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<SoundlangCustomlangs>(entity =>
            {
                entity.ToTable("soundlang_customlangs");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description")
                    .HasColumnType("varchar(80)");

                entity.Property(e => e.Language)
                    .IsRequired()
                    .HasColumnName("language")
                    .HasColumnType("varchar(20)");
            });

            modelBuilder.Entity<SoundlangPackages>(entity =>
            {
                entity.ToTable("soundlang_packages");

                entity.HasIndex(e => e.Id)
                    .HasName("id")
                    .IsUnique();

                entity.HasIndex(e => new { e.Type, e.Module, e.Language, e.Format })
                    .HasName("unique")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.Author)
                    .HasColumnName("author")
                    .HasColumnType("varchar(80)");

                entity.Property(e => e.Authorlink)
                    .HasColumnName("authorlink")
                    .HasColumnType("varchar(256)");

                entity.Property(e => e.Format)
                    .IsRequired()
                    .HasColumnName("format")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Installed)
                    .HasColumnName("installed")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Language)
                    .IsRequired()
                    .HasColumnName("language")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.License).HasColumnName("license");

                entity.Property(e => e.Module)
                    .IsRequired()
                    .HasColumnName("module")
                    .HasColumnType("varchar(80)");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasColumnName("type")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Version)
                    .HasColumnName("version")
                    .HasColumnType("varchar(20)");
            });

            modelBuilder.Entity<SoundlangSettings>(entity =>
            {
                entity.HasKey(e => e.Keyword);

                entity.ToTable("soundlang_settings");

                entity.Property(e => e.Keyword)
                    .HasColumnName("keyword")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasColumnName("value")
                    .HasColumnType("varchar(80)");
            });

            modelBuilder.Entity<Superfectacache>(entity =>
            {
                entity.HasKey(e => e.Number);

                entity.ToTable("superfectacache");

                entity.Property(e => e.Number).HasColumnName("number");

                entity.Property(e => e.Callerid)
                    .IsRequired()
                    .HasColumnName("callerid")
                    .HasColumnType("varchar(45)");

                entity.Property(e => e.Dateentered)
                    .HasColumnName("dateentered")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<Superfectaconfig>(entity =>
            {
                entity.HasKey(e => new { e.Source, e.Field });

                entity.ToTable("superfectaconfig");

                entity.Property(e => e.Source)
                    .HasColumnName("source")
                    .HasColumnType("varchar(150)");

                entity.Property(e => e.Field)
                    .HasColumnName("field")
                    .HasColumnType("varchar(150)");

                entity.Property(e => e.Value)
                    .HasColumnName("value")
                    .HasColumnType("text");
            });

            modelBuilder.Entity<SuperfectaMf>(entity =>
            {
                entity.ToTable("superfecta_mf");

                entity.HasIndex(e => e.TimestampStart)
                    .HasName("start_time");

                entity.Property(e => e.SuperfectaMfId)
                    .HasColumnName("superfecta_mf_id")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.Cidnum)
                    .HasColumnName("cidnum")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.Debug)
                    .HasColumnName("debug")
                    .HasColumnType("tinyint(4)");

                entity.Property(e => e.Extension)
                    .HasColumnName("extension")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.Prefix)
                    .HasColumnName("prefix")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.Scheme)
                    .HasColumnName("scheme")
                    .HasColumnType("varchar(64)");

                entity.Property(e => e.SpamChildId)
                    .HasColumnName("spam_child_id")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.TimestampEnd).HasColumnName("timestamp_end");

                entity.Property(e => e.TimestampStart).HasColumnName("timestamp_start");

                entity.Property(e => e.WinningChildId)
                    .HasColumnName("winning_child_id")
                    .HasColumnType("bigint(20)");
            });

            modelBuilder.Entity<SuperfectaMfChild>(entity =>
            {
                entity.ToTable("superfecta_mf_child");

                entity.HasIndex(e => e.SuperfectaMfId)
                    .HasName("superfecta_mf_id");

                entity.HasIndex(e => e.TimestampStart)
                    .HasName("start_time");

                entity.Property(e => e.SuperfectaMfChildId)
                    .HasColumnName("superfecta_mf_child_id")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.Cached)
                    .HasColumnName("cached")
                    .HasColumnType("tinyint(4)");

                entity.Property(e => e.Cnam)
                    .HasColumnName("cnam")
                    .HasColumnType("varchar(128)");

                entity.Property(e => e.DebugResult)
                    .HasColumnName("debug_result")
                    .HasColumnType("text");

                entity.Property(e => e.ErrorResult)
                    .HasColumnName("error_result")
                    .HasColumnType("text");

                entity.Property(e => e.Priority)
                    .HasColumnName("priority")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Source)
                    .HasColumnName("source")
                    .HasColumnType("varchar(128)");

                entity.Property(e => e.Spam)
                    .HasColumnName("spam")
                    .HasColumnType("int(11)");

                entity.Property(e => e.SpamText)
                    .HasColumnName("spam_text")
                    .HasColumnType("varchar(64)");

                entity.Property(e => e.SuperfectaMfId)
                    .HasColumnName("superfecta_mf_id")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.TimestampCnam).HasColumnName("timestamp_cnam");

                entity.Property(e => e.TimestampEnd).HasColumnName("timestamp_end");

                entity.Property(e => e.TimestampStart).HasColumnName("timestamp_start");
            });

            modelBuilder.Entity<SuperfectaToIncoming>(entity =>
            {
                entity.ToTable("superfecta_to_incoming");

                entity.HasIndex(e => new { e.Extension, e.Cidnum })
                    .HasName("extn")
                    .IsUnique();

                entity.Property(e => e.SuperfectaToIncomingId)
                    .HasColumnName("superfecta_to_incoming_id")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.Cidnum)
                    .HasColumnName("cidnum")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.Extension)
                    .HasColumnName("extension")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.Scheme)
                    .IsRequired()
                    .HasColumnName("scheme")
                    .HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<SysadminUpdateLog>(entity =>
            {
                entity.ToTable("sysadmin_update_log");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.StatusId)
                    .HasColumnName("status_id")
                    .HasColumnType("smallint(6)");

                entity.Property(e => e.Time)
                    .HasColumnName("time")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.Version)
                    .HasColumnName("version")
                    .HasColumnType("varchar(25)");
            });

            modelBuilder.Entity<Timeconditions>(entity =>
            {
                entity.ToTable("timeconditions");

                entity.Property(e => e.TimeconditionsId)
                    .HasColumnName("timeconditions_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CalendarGroupId)
                    .HasColumnName("calendar_group_id")
                    .HasColumnType("varchar(150)");

                entity.Property(e => e.CalendarId)
                    .HasColumnName("calendar_id")
                    .HasColumnType("varchar(150)");

                entity.Property(e => e.Deptname)
                    .HasColumnName("deptname")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.Displayname)
                    .HasColumnName("displayname")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.Falsegoto)
                    .HasColumnName("falsegoto")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.FccPassword)
                    .HasColumnName("fcc_password")
                    .HasColumnType("varchar(20)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.GenerateHint)
                    .HasColumnName("generate_hint")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.InvertHint)
                    .HasColumnName("invert_hint")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Mode)
                    .HasColumnName("mode")
                    .HasColumnType("varchar(20)")
                    .HasDefaultValueSql("'time-group'");

                entity.Property(e => e.Priority)
                    .HasColumnName("priority")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.Time)
                    .HasColumnName("time")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Timezone)
                    .HasColumnName("timezone")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.Truegoto)
                    .HasColumnName("truegoto")
                    .HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<TimegroupsDetails>(entity =>
            {
                entity.ToTable("timegroups_details");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Time)
                    .IsRequired()
                    .HasColumnName("time")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Timegroupid)
                    .HasColumnName("timegroupid")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<TimegroupsGroups>(entity =>
            {
                entity.ToTable("timegroups_groups");

                entity.HasIndex(e => e.Description)
                    .HasName("display")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<TrunkDialpatterns>(entity =>
            {
                entity.HasKey(e => new { e.Trunkid, e.MatchPatternPrefix, e.MatchPatternPass, e.PrependDigits, e.Seq });

                entity.ToTable("trunk_dialpatterns");

                entity.Property(e => e.Trunkid)
                    .HasColumnName("trunkid")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.MatchPatternPrefix)
                    .HasColumnName("match_pattern_prefix")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.MatchPatternPass)
                    .HasColumnName("match_pattern_pass")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.PrependDigits)
                    .HasColumnName("prepend_digits")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Seq)
                    .HasColumnName("seq")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<Trunks>(entity =>
            {
                entity.HasKey(e => new { e.Trunkid, e.Tech, e.Channelid });

                entity.ToTable("trunks");

                entity.Property(e => e.Trunkid)
                    .HasColumnName("trunkid")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Tech)
                    .HasColumnName("tech")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Channelid)
                    .HasColumnName("channelid")
                    .HasColumnType("varchar(190)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Continue)
                    .HasColumnName("continue")
                    .HasColumnType("varchar(4)")
                    .HasDefaultValueSql("'off'");

                entity.Property(e => e.Dialoutprefix)
                    .IsRequired()
                    .HasColumnName("dialoutprefix")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Disabled)
                    .HasColumnName("disabled")
                    .HasColumnType("varchar(4)")
                    .HasDefaultValueSql("'off'");

                entity.Property(e => e.Failscript)
                    .IsRequired()
                    .HasColumnName("failscript")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Keepcid)
                    .HasColumnName("keepcid")
                    .HasColumnType("varchar(4)")
                    .HasDefaultValueSql("'off'");

                entity.Property(e => e.Maxchans)
                    .HasColumnName("maxchans")
                    .HasColumnType("varchar(6)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Outcid)
                    .IsRequired()
                    .HasColumnName("outcid")
                    .HasColumnType("varchar(40)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Provider)
                    .HasColumnName("provider")
                    .HasColumnType("varchar(40)");

                entity.Property(e => e.Usercontext)
                    .HasColumnName("usercontext")
                    .HasColumnType("varchar(255)");
            });

            modelBuilder.Entity<Tts>(entity =>
            {
                entity.ToTable("tts");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Engine)
                    .HasColumnName("engine")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.Goto)
                    .HasColumnName("goto")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.Text)
                    .IsRequired()
                    .HasColumnName("text")
                    .HasColumnType("longtext");
            });

            modelBuilder.Entity<Ttsengines>(entity =>
            {
                entity.ToTable("ttsengines");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.Path)
                    .HasColumnName("path")
                    .HasColumnType("varchar(255)");
            });

            modelBuilder.Entity<UcpSessions>(entity =>
            {
                entity.HasKey(e => e.Session);

                entity.ToTable("ucp_sessions");

                entity.HasIndex(e => e.Session)
                    .HasName("session_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.Session)
                    .HasColumnName("session")
                    .HasColumnType("varchar(190)");

                entity.Property(e => e.Address)
                    .HasColumnName("address")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.Socketid)
                    .HasColumnName("socketid")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.Time)
                    .HasColumnName("time")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Uid)
                    .HasColumnName("uid")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<UsermanDirectories>(entity =>
            {
                entity.ToTable("userman_directories");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Active)
                    .HasColumnName("active")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Default)
                    .HasColumnName("default")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Driver)
                    .IsRequired()
                    .HasColumnName("driver")
                    .HasColumnType("varchar(150)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Locked)
                    .HasColumnName("locked")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasColumnType("varchar(250)");

                entity.Property(e => e.Order)
                    .HasColumnName("order")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'5'");
            });

            modelBuilder.Entity<UsermanGroups>(entity =>
            {
                entity.ToTable("userman_groups");

                entity.HasIndex(e => new { e.Groupname, e.Auth })
                    .HasName("groupname_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Auth)
                    .HasColumnName("auth")
                    .HasColumnType("varchar(150)")
                    .HasDefaultValueSql("'freepbx'");

                entity.Property(e => e.Authid)
                    .HasColumnName("authid")
                    .HasColumnType("varchar(750)");

                entity.Property(e => e.Dateformat)
                    .HasColumnName("dateformat")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.Datetimeformat)
                    .HasColumnName("datetimeformat")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.Groupname)
                    .HasColumnName("groupname")
                    .HasColumnType("varchar(150)");

                entity.Property(e => e.Language)
                    .HasColumnName("language")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.Local)
                    .HasColumnName("local")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Permissions).HasColumnName("permissions");

                entity.Property(e => e.Priority)
                    .HasColumnName("priority")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'5'");

                entity.Property(e => e.Timeformat)
                    .HasColumnName("timeformat")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.Timezone)
                    .HasColumnName("timezone")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.Users).HasColumnName("users");
            });

            modelBuilder.Entity<UsermanUsers>(entity =>
            {
                entity.ToTable("userman_users");

                entity.HasIndex(e => new { e.Username, e.Auth })
                    .HasName("username_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Auth)
                    .HasColumnName("auth")
                    .HasColumnType("varchar(150)")
                    .HasDefaultValueSql("'freepbx'");

                entity.Property(e => e.Authid)
                    .HasColumnName("authid")
                    .HasColumnType("varchar(750)");

                entity.Property(e => e.Cell)
                    .HasColumnName("cell")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.Company)
                    .HasColumnName("company")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.Dateformat)
                    .HasColumnName("dateformat")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.Datetimeformat)
                    .HasColumnName("datetimeformat")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.DefaultExtension)
                    .IsRequired()
                    .HasColumnName("default_extension")
                    .HasColumnType("varchar(45)")
                    .HasDefaultValueSql("'none'");

                entity.Property(e => e.Department)
                    .HasColumnName("department")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.Displayname)
                    .HasColumnName("displayname")
                    .HasColumnType("varchar(200)");

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasColumnType("longtext");

                entity.Property(e => e.Fax)
                    .HasColumnName("fax")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.Fname)
                    .HasColumnName("fname")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.Home)
                    .HasColumnName("home")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.Language)
                    .HasColumnName("language")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.Lname)
                    .HasColumnName("lname")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.Password)
                    .HasColumnName("password")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.Permissions).HasColumnName("permissions");

                entity.Property(e => e.PrimaryGroup)
                    .HasColumnName("primary_group")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Timeformat)
                    .HasColumnName("timeformat")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.Timezone)
                    .HasColumnName("timezone")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.Title)
                    .HasColumnName("title")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.Username)
                    .HasColumnName("username")
                    .HasColumnType("varchar(150)");

                entity.Property(e => e.Work)
                    .HasColumnName("work")
                    .HasColumnType("varchar(100)");
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.HasKey(e => e.Extension);

                entity.ToTable("users");

                entity.HasIndex(e => e.Extension)
                    .HasName("extension");

                entity.Property(e => e.Extension)
                    .HasColumnName("extension")
                    .HasColumnType("varchar(20)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.BusyCid)
                    .IsRequired()
                    .HasColumnName("busy_cid")
                    .HasColumnType("varchar(20)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.BusyDest)
                    .IsRequired()
                    .HasColumnName("busy_dest")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ChanunavailCid)
                    .IsRequired()
                    .HasColumnName("chanunavail_cid")
                    .HasColumnType("varchar(20)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ChanunavailDest)
                    .IsRequired()
                    .HasColumnName("chanunavail_dest")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Mohclass)
                    .HasColumnName("mohclass")
                    .HasColumnType("varchar(80)")
                    .HasDefaultValueSql("'default'");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.Noanswer)
                    .HasColumnName("noanswer")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.NoanswerCid)
                    .IsRequired()
                    .HasColumnName("noanswer_cid")
                    .HasColumnType("varchar(20)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.NoanswerDest)
                    .IsRequired()
                    .HasColumnName("noanswer_dest")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Outboundcid)
                    .HasColumnName("outboundcid")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.Password)
                    .HasColumnName("password")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Recording)
                    .HasColumnName("recording")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.Ringtimer)
                    .HasColumnName("ringtimer")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Sipname)
                    .HasColumnName("sipname")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.Voicemail)
                    .HasColumnName("voicemail")
                    .HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<VirtualQueueConfig>(entity =>
            {
                entity.ToTable("virtual_queue_config");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Adest)
                    .IsRequired()
                    .HasColumnName("adest")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.AgentannounceId)
                    .HasColumnName("agentannounce_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Alertinfo)
                    .IsRequired()
                    .HasColumnName("alertinfo")
                    .HasColumnType("varchar(254)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CallconfirmId)
                    .HasColumnName("callconfirm_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Cdest)
                    .IsRequired()
                    .HasColumnName("cdest")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Cidpp)
                    .IsRequired()
                    .HasColumnName("cidpp")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Dest)
                    .IsRequired()
                    .HasColumnName("dest")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.FullDest)
                    .IsRequired()
                    .HasColumnName("full_dest")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Gotodest)
                    .IsRequired()
                    .HasColumnName("gotodest")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.JoinannounceId)
                    .HasColumnName("joinannounce_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.JoinemptyDest)
                    .IsRequired()
                    .HasColumnName("joinempty_dest")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.JoinunavailDest)
                    .IsRequired()
                    .HasColumnName("joinunavail_dest")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Language)
                    .IsRequired()
                    .HasColumnName("language")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.LeaveemptyDest)
                    .IsRequired()
                    .HasColumnName("leaveempty_dest")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.LeaveunavailDest)
                    .IsRequired()
                    .HasColumnName("leaveunavail_dest")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.MaxPenalty)
                    .HasColumnName("max_penalty")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Maxwait)
                    .HasColumnName("maxwait")
                    .HasColumnType("varchar(8)");

                entity.Property(e => e.MinPenalty)
                    .HasColumnName("min_penalty")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Music)
                    .HasColumnName("music")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("varchar(40)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Position)
                    .HasColumnName("position")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Priority)
                    .HasColumnName("priority")
                    .HasColumnType("int(11)");

                entity.Property(e => e.RuleId)
                    .HasColumnName("rule_id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<Vmblast>(entity =>
            {
                entity.HasKey(e => e.Grpnum);

                entity.ToTable("vmblast");

                entity.Property(e => e.Grpnum)
                    .HasColumnName("grpnum")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.AudioLabel)
                    .HasColumnName("audio_label")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'-1'");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description")
                    .HasColumnType("varchar(35)");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasColumnName("password")
                    .HasColumnType("varchar(20)");
            });

            modelBuilder.Entity<VmblastGroups>(entity =>
            {
                entity.HasKey(e => new { e.Grpnum, e.Ext });

                entity.ToTable("vmblast_groups");

                entity.Property(e => e.Grpnum)
                    .HasColumnName("grpnum")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.Ext)
                    .HasColumnName("ext")
                    .HasColumnType("varchar(25)")
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<Vmnotify>(entity =>
            {
                entity.HasKey(e => e.Mailbox);

                entity.ToTable("vmnotify");

                entity.Property(e => e.Mailbox)
                    .HasColumnName("mailbox")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Cidtype)
                    .IsRequired()
                    .HasColumnName("cidtype")
                    .HasColumnType("varchar(24)")
                    .HasDefaultValueSql("'default'");

                entity.Property(e => e.Deletemsg)
                    .IsRequired()
                    .HasColumnName("deletemsg")
                    .HasColumnType("varchar(5)")
                    .HasDefaultValueSql("'yes'");

                entity.Property(e => e.Emailattach)
                    .HasColumnName("emailattach")
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Emailbody)
                    .IsRequired()
                    .HasColumnName("emailbody")
                    .HasColumnType("text");

                entity.Property(e => e.Emailfail)
                    .IsRequired()
                    .HasColumnName("emailfail")
                    .HasColumnType("text");

                entity.Property(e => e.Emailfrom)
                    .IsRequired()
                    .HasColumnName("emailfrom")
                    .HasColumnType("varchar(256)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Emailsubject)
                    .IsRequired()
                    .HasColumnName("emailsubject")
                    .HasColumnType("varchar(256)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Emailsuccess)
                    .IsRequired()
                    .HasColumnName("emailsuccess")
                    .HasColumnType("text");

                entity.Property(e => e.Enabled)
                    .HasColumnName("enabled")
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Getname)
                    .HasColumnName("getname")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Greetingid)
                    .HasColumnName("greetingid")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Instructionsid)
                    .HasColumnName("instructionsid")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Outcid)
                    .IsRequired()
                    .HasColumnName("outcid")
                    .HasColumnType("varchar(56)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Outcidname)
                    .IsRequired()
                    .HasColumnName("outcidname")
                    .HasColumnType("varchar(56)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Prioritydelay)
                    .HasColumnName("prioritydelay")
                    .HasDefaultValueSql("'120'");

                entity.Property(e => e.Recipients)
                    .IsRequired()
                    .HasColumnName("recipients")
                    .HasColumnType("text");

                entity.Property(e => e.Retrycount)
                    .HasColumnName("retrycount")
                    .HasDefaultValueSql("'3'");

                entity.Property(e => e.Retrydelay)
                    .HasColumnName("retrydelay")
                    .HasDefaultValueSql("'300'");
            });

            modelBuilder.Entity<VmnotifyEvents>(entity =>
            {
                entity.ToTable("vmnotify_events");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.NotificationId)
                    .HasColumnName("notification_id")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Number)
                    .IsRequired()
                    .HasColumnName("number")
                    .HasColumnType("varchar(32)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Priority)
                    .HasColumnName("priority")
                    .HasColumnType("int(10)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Time).HasColumnName("time");
            });

            modelBuilder.Entity<VmnotifyNotifications>(entity =>
            {
                entity.ToTable("vmnotify_notifications");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Callerid)
                    .IsRequired()
                    .HasColumnName("callerid")
                    .HasColumnType("varchar(64)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Length)
                    .HasColumnName("length")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Mailbox)
                    .IsRequired()
                    .HasColumnName("mailbox")
                    .HasColumnType("varchar(20)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Priority)
                    .HasColumnName("priority")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Retry)
                    .HasColumnName("retry")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Time).HasColumnName("time");
            });

            modelBuilder.Entity<VoicemailAdmin>(entity =>
            {
                entity.HasKey(e => e.Variable);

                entity.ToTable("voicemail_admin");

                entity.Property(e => e.Variable)
                    .HasColumnName("variable")
                    .HasColumnType("varchar(30)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasColumnName("value")
                    .HasColumnType("varchar(80)")
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<VqplusCallbackCalls>(entity =>
            {
                entity.HasKey(e => e.Uniqueid);

                entity.ToTable("vqplus_callback_calls");

                entity.Property(e => e.Uniqueid)
                    .HasColumnName("uniqueid")
                    .HasColumnType("varchar(40)");

                entity.Property(e => e.Callback)
                    .IsRequired()
                    .HasColumnName("callback")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Cbid)
                    .HasColumnName("cbid")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Position)
                    .HasColumnName("position")
                    .HasColumnType("int(11)");

                entity.Property(e => e.QueueNum)
                    .IsRequired()
                    .HasColumnName("queue_num")
                    .HasColumnType("varchar(20)");
            });

            modelBuilder.Entity<VqplusCallbackConfig>(entity =>
            {
                entity.ToTable("vqplus_callback_config");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Announcement)
                    .HasColumnName("announcement")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.Cbdfcountry)
                    .HasColumnName("cbdfcountry")
                    .HasColumnType("varchar(4)");

                entity.Property(e => e.Cbendtime)
                    .HasColumnName("cbendtime")
                    .HasColumnType("varchar(8)");

                entity.Property(e => e.Cbqueue)
                    .HasColumnName("cbqueue")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Cbstarttime)
                    .HasColumnName("cbstarttime")
                    .HasColumnType("varchar(8)");

                entity.Property(e => e.Cbtiming)
                    .HasColumnName("cbtiming")
                    .HasColumnType("tinyint(1)");

                entity.Property(e => e.Cid)
                    .HasColumnName("cid")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.Forcecid)
                    .HasColumnName("forcecid")
                    .HasColumnType("tinyint(1)");

                entity.Property(e => e.Maxcallbacks)
                    .HasColumnName("maxcallbacks")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("varchar(40)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Numprepend)
                    .HasColumnName("numprepend")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Patterns)
                    .HasColumnName("patterns")
                    .HasColumnType("longtext");

                entity.Property(e => e.Promptcb)
                    .HasColumnName("promptcb")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.Promptcbaccept)
                    .HasColumnName("promptcbaccept")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.Promptreqconfirm)
                    .HasColumnName("promptreqconfirm")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.Promptreqname)
                    .HasColumnName("promptreqname")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.Promptreqnum)
                    .HasColumnName("promptreqnum")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.Recordname)
                    .HasColumnName("recordname")
                    .HasColumnType("tinyint(1)");

                entity.Property(e => e.Retries)
                    .HasColumnName("retries")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Retrydelay)
                    .HasColumnName("retrydelay")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Timeout)
                    .HasColumnName("timeout")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<VqplusCallbackLog>(entity =>
            {
                entity.HasKey(e => e.Uniqueid);

                entity.ToTable("vqplus_callback_log");

                entity.Property(e => e.Uniqueid)
                    .HasColumnName("uniqueid")
                    .HasColumnType("varchar(40)");

                entity.Property(e => e.Callback)
                    .IsRequired()
                    .HasColumnName("callback")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Cbid)
                    .HasColumnName("cbid")
                    .HasColumnType("int(11)");

                entity.Property(e => e.QueueNum)
                    .IsRequired()
                    .HasColumnName("queue_num")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Reason)
                    .IsRequired()
                    .HasColumnName("reason")
                    .HasColumnType("varchar(80)");

                entity.Property(e => e.Success)
                    .HasColumnName("success")
                    .HasColumnType("tinyint(1)");

                entity.Property(e => e.Timestamp)
                    .HasColumnName("timestamp")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<VqplusQruleConfig>(entity =>
            {
                entity.ToTable("vqplus_qrule_config");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("varchar(40)")
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<VqplusQruleDetail>(entity =>
            {
                entity.HasKey(e => new { e.RuleId, e.Elapsed });

                entity.ToTable("vqplus_qrule_detail");

                entity.Property(e => e.RuleId)
                    .HasColumnName("rule_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Elapsed)
                    .HasColumnName("elapsed")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MaxPenalty)
                    .IsRequired()
                    .HasColumnName("max_penalty")
                    .HasColumnType("varchar(10)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.MinPenalty)
                    .IsRequired()
                    .HasColumnName("min_penalty")
                    .HasColumnType("varchar(10)")
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<VqplusQueueConfig>(entity =>
            {
                entity.HasKey(e => e.QueueNum);

                entity.ToTable("vqplus_queue_config");

                entity.Property(e => e.QueueNum)
                    .HasColumnName("queue_num")
                    .HasColumnType("varchar(20)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Adest)
                    .IsRequired()
                    .HasColumnName("adest")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Cdest)
                    .IsRequired()
                    .HasColumnName("cdest")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.FullDest)
                    .IsRequired()
                    .HasColumnName("full_dest")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.JoinemptyDest)
                    .IsRequired()
                    .HasColumnName("joinempty_dest")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.JoinunavailDest)
                    .IsRequired()
                    .HasColumnName("joinunavail_dest")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Lazymembers)
                    .IsRequired()
                    .HasColumnName("lazymembers")
                    .HasColumnType("varchar(6)")
                    .HasDefaultValueSql("'no'");

                entity.Property(e => e.LeaveemptyDest)
                    .IsRequired()
                    .HasColumnName("leaveempty_dest")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.LeaveunavailDest)
                    .IsRequired()
                    .HasColumnName("leaveunavail_dest")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.MaxPenalty)
                    .HasColumnName("max_penalty")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MinPenalty)
                    .HasColumnName("min_penalty")
                    .HasColumnType("int(11)");

                entity.Property(e => e.RuleId)
                    .HasColumnName("rule_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Upil)
                    .IsRequired()
                    .HasColumnName("upil")
                    .HasColumnType("varchar(6)")
                    .HasDefaultValueSql("'no'");
            });

            modelBuilder.Entity<Webcallback>(entity =>
            {
                entity.ToTable("webcallback");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Accountcode)
                    .HasColumnName("accountcode")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ButtonAttr)
                    .HasColumnName("button_attr")
                    .HasColumnType("text");

                entity.Property(e => e.Cidprepend)
                    .HasColumnName("cidprepend")
                    .HasColumnType("varchar(25)");

                entity.Property(e => e.Dest)
                    .HasColumnName("dest")
                    .HasColumnType("varchar(150)");

                entity.Property(e => e.DialpadAttr)
                    .HasColumnName("dialpad_attr")
                    .HasColumnType("text");

                entity.Property(e => e.ErrorMsg)
                    .HasColumnName("error_msg")
                    .HasColumnType("text");

                entity.Property(e => e.Icon)
                    .HasColumnName("icon")
                    .HasColumnType("varchar(25)");

                entity.Property(e => e.InvalidMsg)
                    .HasColumnName("invalid_msg")
                    .HasColumnType("text");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.Numprepend)
                    .HasColumnName("numprepend")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.Patterns)
                    .HasColumnName("patterns")
                    .HasColumnType("text");

                entity.Property(e => e.ValidMsg)
                    .HasColumnName("valid_msg")
                    .HasColumnType("text");
            });

            modelBuilder.Entity<XmppOptions>(entity =>
            {
                entity.HasKey(e => e.Keyword);

                entity.ToTable("xmpp_options");

                entity.Property(e => e.Keyword)
                    .HasColumnName("keyword")
                    .HasColumnType("varchar(75)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Value)
                    .HasColumnName("value")
                    .HasColumnType("text");
            });

            modelBuilder.Entity<XmppUsers>(entity =>
            {
                entity.HasKey(e => e.User);

                entity.ToTable("xmpp_users");

                entity.Property(e => e.User)
                    .HasColumnName("user")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Password)
                    .HasColumnName("password")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.Username)
                    .HasColumnName("username")
                    .HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<ZuluSoftphones>(entity =>
            {
                entity.HasKey(e => e.User);

                entity.ToTable("zulu_softphones");

                entity.Property(e => e.User)
                    .HasColumnName("user")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Certid)
                    .HasColumnName("certid")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Device)
                    .HasColumnName("device")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<ZuluTokens>(entity =>
            {
                entity.HasKey(e => new { e.Uid, e.Token });

                entity.ToTable("zulu_tokens");

                entity.Property(e => e.Uid)
                    .HasColumnName("uid")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Token)
                    .HasColumnName("token")
                    .HasColumnType("varchar(36)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Client)
                    .HasColumnName("client")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.Connecttime)
                    .HasColumnName("connecttime")
                    .HasColumnType("int(11)");
            });
        }
    }
}
