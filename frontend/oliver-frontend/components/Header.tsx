import AuthButton from './AuthButton'
import { createClient } from '@/utils/supabase/server'
import { cookies } from 'next/headers'

export default function Header() {
  const cookieStore = cookies()
  const supabase = createClient(cookieStore)

  const canInitSupabaseClient = () => {
    // This function is just for the interactive tutorial.
    // Feel free to remove it once you have Supabase connected.
    try {
      createClient(cookieStore)
      return true
    } catch (e) {
      return false
    }
  }



  const isSupabaseConnected = canInitSupabaseClient()
  return (
    <div className="flex-1 w-screen flex flex-col gap-20 items-center">
      <nav className="w-full flex border-b border-b-foreground/10 h-16">
        <div className="w-full max-w-4xl flex p-3 text-sm">
          {isSupabaseConnected && <AuthButton />}
        </div>
      </nav>
    </div>
  )
}
