namespace LineStatus.Api.Models.Entities;

public class cds_desk
{
    public int desk_id { get; set; }
    public string desk_name { get; set; }
    public string desk_ip { get; set; }
    public string desk_username { get; set; }
    public string desk_password { get; set; }
    public string desk_number { get; set; }
    public int desk_smdisplay_address { get; set; }
    public int desk_underusage { get; set; }
    public int desk_actual_nr { get; set; }
    public int desk_actual_servgr_id { get; set; }
    public int desk_actual_service { get; set; }
    public int desk_actual_user_id { get; set; }
    public int desk_deleted { get; set; }
    public int desk_actual_data_id { get; set; }
    public int desk_use_registry { get; set; }
    public int desk_last_login_time { get; set; }
    public int desk_active { get; set; }
    public int desk_actual_function { get; set; }
    public int desk_mainframe_id { get; set; }
    public int desk_allow_put_waitlist { get; set; }
    public int desk_allow_call_waitlist { get; set; }
    public int desk_allow_service_change { get; set; }
    public int desk_allow_brake { get; set; }
    public int desk_allow_servicechange_with_code { get; set; }
    public int desk_allow_transfer_with_code { get; set; }
    public int desk_allow_waitlist_with_code { get; set; }
    public int desk_allow_close_with_code { get; set; }
    public int desk_sound_if_waiting_1 { get; set; }
    public int desk_popup_if_waiting_1 { get; set; }
    public int desk_changed { get; set; }
    public int desk_show_client_list { get; set; }
    public int desk_call_from_client_list { get; set; }
    public int desk_show_service_in_client_list { get; set; }
    public int desk_show_waittime_in_client_list { get; set; }
    public int desk_window_x_position { get; set; }
    public int desk_window_y_position { get; set; }
    public int desk_client_list_window_x_position { get; set; }
    public int desk_client_list_window_y_position { get; set; }
    public int desk_default_deskuser_id { get; set; }
    public int desk_default_servgr_id { get; set; }
    public int desk_pop_up_on_admin_time { get; set; }
    public int desk_give_sound_on_admin_time { get; set; }
    public int desk_critical_client_count { get; set; }
    public int desk_speaker_direction { get; set; }
    public int desk_desk_group { get; set; }
    public int desk_allow_own_service { get; set; }
    public int desk_client_version { get; set; }
    public int desk_display_type { get; set; }
    public int desk_hw_keyboard { get; set; }
}