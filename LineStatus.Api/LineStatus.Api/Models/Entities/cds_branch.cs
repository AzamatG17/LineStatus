using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace LineStatus.Api.Models.Entities;

[Table("cds_branch", Schema = "dbo")]
public class cds_branch
{
    [Key]
    [Column("branch_id")]
    public int branch_id { get; set; }

    [Column("branch_name")]
    public string branch_name { get; set; }

    [Column("branch_host")]
    public string branch_host { get; set; }

    [Column("branch_ip")]
    public string branch_ip { get; set; }

    [Column("branch_db_name")]
    public string branch_db_name { get; set; }

    [Column("branch_db_username")]
    public string branch_db_username { get; set; }

    [Column("branch_db_password")]
    public string branch_db_password { get; set; }

    [Column("branch_charid")]
    public string? branch_charid { get; set; }

    [Column("branch_numid")]
    public string? branch_numid { get; set; }

    [Column("branch_registered")]
    public int? branch_registered { get; set; }

    [Column("branch_deleted")]
    public int? branch_deleted { get; set; }

    [Column("branch_description")]
    public string? branch_description { get; set; }

    [Column("branch_unregistered")]
    public int branch_unregistered { get; set; }

    [Column("branch_syncron_done")]
    public int? branch_syncron_done { get; set; }

    [Column("branch_db_type")]
    public int branch_db_type { get; set; }

    [Column("branch_soap_port")]
    public int branch_soap_port { get; set; }

    [Column("branch_active_template")]
    public int branch_active_template { get; set; }

    [Column("branch_active_template_since")]
    public int branch_active_template_since { get; set; }

    [Column("branch_syncron_running")]
    public int branch_syncron_running { get; set; }

    [Column("branch_syncron_start_time")]
    public int branch_syncron_start_time { get; set; }

    [Column("branch_syncron_timeout")]
    public int branch_syncron_timeout { get; set; }

    [Column("branch_cds_version")]
    public string? branch_cds_version { get; set; }

    [Column("branch_cc_id")]
    public string? branch_cc_id { get; set; }

    [Column("branch_mkb_id")]
    public string? branch_mkb_id { get; set; }

    [Column("branch_office_id")]
    public string? branch_office_id { get; set; }

    [Column("branch_max_service_per_deskuser")]
    public int? branch_max_service_per_deskuser { get; set; }

    [Column("branch_geocode")]
    public string? branch_geocode { get; set; }

    [Column("branch_email_address")]
    public string? branch_email_address { get; set; }

    [Column("branch_zip_code")]
    public string? branch_zip_code { get; set; }

    [Column("branch_city")]
    public string? branch_city { get; set; }

    [Column("branch_street")]
    public string? branch_street { get; set; }

    [Column("branch_street_number")]
    public string? branch_street_number { get; set; }

    [Column("branch_phone_number")]
    public string? branch_phone_number { get; set; }

    [Column("branch_validation_data")]
    public string? branch_validation_data { get; set; }

    [Column("branch_map_id")]
    public int branch_map_id { get; set; }

    [Column("branch_max_booking_no_at_the_same_time")]
    public int branch_max_booking_no_at_the_same_time { get; set; }

    [Column("branch_disabled_access")]
    public int branch_disabled_access { get; set; }

    [Column("branch_opening_info")]
    public string? branch_opening_info { get; set; }

    [Column("branch_avg_wait_time_is_alerted")]
    public int branch_avg_wait_time_is_alerted { get; set; }

    [Column("branch_queuing_branch_id")]
    public int branch_queuing_branch_id { get; set; }

    [Column("branch_ssis_connection_string")]
    public string? branch_ssis_connection_string { get; set; }

    [Column("branch_settings_template_id")]
    public int? branch_settings_template_id { get; set; }

    [Column("totem_service_url")]
    public string? totem_service_url { get; set; }

    [Column("branch_active")]
    public int branch_active { get; set; }

    [Column("branch_token_id")]
    public string? branch_token_id { get; set; }

    [Column("branch_unique_message")]
    public string? branch_unique_message { get; set; }

    [Column("cds_updater_service_url")]
    public string? cds_updater_service_url { get; set; }
}
